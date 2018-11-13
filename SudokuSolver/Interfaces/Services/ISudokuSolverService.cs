using System;

namespace SudokuSolver.Interfaces.Services
{
    public interface ISudokuSolverService
    {
        bool Solved { get; }
        int?[][] Sudoku { get; }
        void SolveSudoku();
    }
}
