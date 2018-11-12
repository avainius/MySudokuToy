using SudokuSolver.Interfaces.Models;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.SudokuModels
{
    public class SudokuCellModel : ISudokuCellModel
    {
        private int? _currentValue { get; set; }
        public int? CurrentValue => _currentValue;
        public int? SoleCandidate => PossibleValues.Count == 1 ? (int?)PossibleValues.First() : null;

        public List<int> ValidValues { get; }

        public List<int> PossibleValues => ValidValues.Where(x => !EliminatedValues.Contains(x) && 
        (CurrentValue == null || !ValidValues.Contains(CurrentValue.Value))).ToList();

        public List<int> EliminatedValues { get; }

        public SudokuCellModel(int? value)
        {
            ValidValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            EliminatedValues = new List<int>();
            _currentValue = value;
        }

        public void ClearCellValue() => throw new System.NotImplementedException();
        public int? SetCellValue(int? value) => throw new System.NotImplementedException();
        public void EliminateValue(int value)
        { 
            EliminatedValues.Add(value);
        }

        public void ClearEliminatedList() => throw new System.NotImplementedException();
    }
}
