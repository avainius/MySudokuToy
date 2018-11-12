using SudokuSolver.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace SudokuSolver.SudokuModels
{
    public class SudokuBlockModel : ISudokuBlockModel
    {
        public ISudokuCellModel[][] Block => throw new NotImplementedException();

        public List<ISudokuCellModel> EmptyCells => throw new NotImplementedException();

        public List<ISudokuCellModel> DublicateCells => throw new NotImplementedException();

        public bool BlockSolved() => throw new NotImplementedException();
        public bool HasDublicates() => throw new NotImplementedException();
    }
}
