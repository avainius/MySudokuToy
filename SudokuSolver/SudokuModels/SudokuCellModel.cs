using SudokuSolver.Interfaces.Models;
using System.Collections.Generic;

namespace SudokuSolver.SudokuModels
{
    public class SudokuCellModel : ISudokuCellModel
    {
        public int? CurrentValue => throw new System.NotImplementedException();

        public List<int> ValidValues => throw new System.NotImplementedException();

        public List<int> PossibleValues => throw new System.NotImplementedException();

        public List<int> EliminatedValues => throw new System.NotImplementedException();

        public void ClearCellValue() => throw new System.NotImplementedException();
        public int? SetCellValue(int? value) => throw new System.NotImplementedException();
    }
}
