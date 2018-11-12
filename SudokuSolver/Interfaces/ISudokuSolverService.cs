using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Interfaces
{
    public interface ISudokuSolverService
    {
        bool Solved { get; }
        int?[][] Sudoku { get; set; }
        int?[][] SolveSudoku();
        ValueTuple GetFirstUnfilledCoordinates();
    }
}
