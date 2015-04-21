#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;
#endregion

namespace TreeDim.StackBuilder.Basics
{
    #region PackPalletAnalysis
    public class PackPalletAnalysis : ItemBase
    {
        #region Data members
        private PackProperties _packProperties;
        private PalletProperties _palletProperties;
        private InterlayerProperties _interlayerProperties;
        private PackPalletConstraintSet _constraintSet;
        private List<PackPalletSolution> _solutions;
        private List<SelPackPalletSolution> _selectedSolutions = new List<SelPackPalletSolution>();
        private static IPackPalletAnalysisSolver _solver;
        static readonly ILog _log = LogManager.GetLogger(typeof(PackPalletAnalysis));
        #endregion

        #region Delegates
        public delegate void ModifyAnalysis(PackPalletAnalysis analysis);
        public delegate void SelectSolution(PackPalletAnalysis analysis, SelPackPalletSolution selSolution);
        #endregion

        #region Events
        public event ModifyAnalysis Modified;
        public event SelectSolution SolutionSelected;
        public event SelectSolution SolutionSelectionRemoved;
        #endregion

        #region Constructor
        public PackPalletAnalysis(
            PackProperties packProperties,
            PalletProperties palletProperties,
            InterlayerProperties interlayerProperties,
            PackPalletConstraintSet constraintSet)
            : base(packProperties.ParentDocument)
        {
            // sanity checks
            if (palletProperties.ParentDocument != ParentDocument
                || (interlayerProperties != null && interlayerProperties.ParentDocument != ParentDocument))
                throw new Exception("box, pallet, interlayer do not belong to the same document");
            // setting members
            this.PackProperties = packProperties;
            this.PalletProperties = palletProperties;
            this.InterlayerProperties = interlayerProperties;
            this.ConstraintSet = constraintSet;
        }
        #endregion

        #region Public properties
        public List<PackPalletSolution> Solutions
        {
            set
            {
                _solutions = value;
                foreach (PackPalletSolution sol in _solutions)
                    sol.Analysis = this;
            }
            get {return _solutions;}
        }

        public PackProperties PackProperties
        {
            get { return _packProperties; }
            set
            {
                if (value == _packProperties) return;
                if (null != _packProperties) _packProperties.RemoveDependancy(this);
                _packProperties = value;
                _packProperties.AddDependancy(this);
            }
        }
        public PalletProperties PalletProperties
        {
            get { return _palletProperties; }
            set
            {
                if (_palletProperties == value) return;
                if (null != _palletProperties) _palletProperties.RemoveDependancy(this);
                _palletProperties = value;
                _palletProperties.AddDependancy(this);
            }
        }
        public InterlayerProperties InterlayerProperties
        {
            get { return _interlayerProperties; }
            set
            {
                if (_interlayerProperties == value) return;
                if (null != _interlayerProperties) _interlayerProperties.RemoveDependancy(this);
                _interlayerProperties = value;
                if (null != _interlayerProperties)
                    _interlayerProperties.AddDependancy(this);
            }
        }
        public PackPalletConstraintSet ConstraintSet
        {
            get { return _constraintSet; }
            set { _constraintSet = value; }
        }

        public bool HasInterlayer
        {   get { return null != _interlayerProperties; } }

        public static IPackPalletAnalysisSolver Solver
        { set { _solver = value; } }
        #endregion

        #region Solution selection
        public void SelectSolutionByIndex(int index)
        {
            if (index < 0 || index > _solutions.Count)
                return; // no solution with this index
            if (HasSolutionSelected(index)) return;
            // instantiate new SelSolution
            SelPackPalletSolution selSolution = new SelPackPalletSolution(ParentDocument, this, _solutions[index]);
            // insert in list
            _selectedSolutions.Add(selSolution);
            // fire event
            if (null != SolutionSelected)
                SolutionSelected(this, selSolution);
            // set document modified (not analysis, otherwise selected solutions are erased)
            ParentDocument.Modify();
        }
        public void UnselectSolutionByIndex(int index)
        {
            UnSelectSolution(GetSelSolutionBySolutionIndex(index));
        }
        public void UnSelectSolution(SelPackPalletSolution selSolution)
        {
            if (null == selSolution) return; // this solution not selected
            // remove from list
            _selectedSolutions.Remove(selSolution);
            ParentDocument.RemoveItem(selSolution);
            // fire event
            if (null != SolutionSelectionRemoved)
                SolutionSelectionRemoved(this, selSolution);
            // set document modified (not analysis, otherwise selected solutions are erased)
            ParentDocument.Modify();
        }
        public bool HasSolutionSelected(int index)
        {
            return (null != GetSelSolutionBySolutionIndex(index));
        }
        public SelPackPalletSolution GetSelSolutionBySolutionIndex(int index)
        {
            if (index < 0 || index > _solutions.Count) return null;  // no solution with this index
            return _selectedSolutions.Find(delegate(SelPackPalletSolution selSol) { return selSol.Solution == _solutions[index]; });
        }
        #endregion

        #region Dependancies
        protected override void OnDispose()
        {
            base.OnDispose();
        }
        protected override void RemoveItselfFromDependancies()
        {
            _packProperties.RemoveDependancy(this);
            _palletProperties.RemoveDependancy(this);
            if (null != _interlayerProperties)
                _interlayerProperties.RemoveDependancy(this);
            // base
            base.RemoveItselfFromDependancies();
        }
        public override void OnAttributeModified(ItemBase modifiedAttribute)
        {
            // clear selected solutions
            while (_selectedSolutions.Count > 0)
                UnSelectSolution(_selectedSolutions[0]);
            // clear solutions
            _solutions.Clear();
            // base
            base.OnAttributeModified(modifiedAttribute);
        }
        public override void OnEndUpdate(ItemBase updatedAttribute)
        {
            base.OnEndUpdate(updatedAttribute);
            if (null != Modified)
                Modified(this);
            // clear solutions
            _solutions.Clear();
            // get default analysis solver
            if (null != _solver)
                _solver.ProcessAnalysis(this);
            else
                _log.Error("_solver == null : solver was not set");
            if (_solutions.Count == 0)
                _log.Debug("Recomputed analysis has no solutions");
            // set modified / propagate modifications
            Modify();
        }
        #endregion
    }
    #endregion

    #region IPackPalletAnalysisSolver
    public interface IPackPalletAnalysisSolver
    {
        void ProcessAnalysis(PackPalletAnalysis analysis);
    }
    #endregion
}
