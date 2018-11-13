using SudokuSolver.Interfaces.Services;
using System;

namespace SudokuSolver.Services
{
    public class SudokuSolverService : ISudokuSolverService
    {
        public bool Solved => throw new NotImplementedException();

        public int?[][] Sudoku => throw new NotImplementedException();

        public void SolveSudoku() => throw new NotImplementedException();
    }
}
