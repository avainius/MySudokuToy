using SudokuSolver.Interfaces.Models;
using System;
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

        public List<int> EliminatedValues { get; private set; }
        public bool Marked { get; set; }

        public SudokuCellModel(int? value)
        {
            ValidValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            EliminatedValues = new List<int>();
            _currentValue = value;
        }

        public void ClearCellValue() => SetCellValue(null);
        public int? SetCellValue(int? value)
        {
            if (value != null && !ValueValid(value.Value))
                throw new ArgumentException($"Trying to set to an invalid value: {value}. " +
                    $"The valid value range is [{ValidValues.Min()};{ValidValues.Max()}].");
            _currentValue = value;
            return _currentValue;
        }

        public void EliminateValue(int value)
        {
            if (!ValueValid(value))
                throw new ArgumentException($"Trying to eliminate an invalid value: {value}. " +
                    $"The valid value range is [{ValidValues.Min()};{ValidValues.Max()}].");
            EliminatedValues.Add(value);
        }

        public void ClearEliminatedList() => EliminatedValues = new List<int>();
        public bool ValueValid(int value) => ValidValues.Contains(value);
    }
}
