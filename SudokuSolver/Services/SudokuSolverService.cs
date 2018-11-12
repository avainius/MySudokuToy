using SudokuSolver.Interfaces.Services;
using System;

namespace SudokuSolver.Services
{
    public class SudokuSolverService : ISudokuSolverService
    {
        public bool Solved => throw new NotImplementedException();

        public int?[][] Sudoku { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ValueTuple GetFirstUnfilledCoordinates() => throw new NotImplementedException();
        public int?[][] SolveSudoku() => throw new NotImplementedException();
    }
}
