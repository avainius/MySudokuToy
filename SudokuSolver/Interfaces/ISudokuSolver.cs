using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Interfaces
{
    public interface ISudokuSolver
    {
        int?[][] Sudoku { get; set; }
        int?[][] SolveSudoku();
        bool ForceValues(int xPos, int yPos, int val);
        bool FillSingles();
        bool Solved();
        ValueTuple GetFirstUnfilledCoordinates();
    }
}
