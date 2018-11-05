using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Services
{
    public class SudokuSolverService : ISudokuSolver
    {
        public int?[][] Sudoku { get; set; }

        public bool FillSingles() => throw new NotImplementedException();
        public bool ForceValues(int xPos, int yPos, int val) => throw new NotImplementedException();
        public ValueTuple GetFirstUnfilledCoordinates() => throw new NotImplementedException();
        public bool Solved() => throw new NotImplementedException();
        public int?[][] SolveSudoku() => throw new NotImplementedException();
    }
}
