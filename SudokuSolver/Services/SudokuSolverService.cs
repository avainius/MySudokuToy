using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Services
{
    public class SudokuSolverService : ISudokuSolver
    {
        public int?[][] Sudoku { get; set; }
        private int[] PossibleValues = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public bool FillSingles()
        {
            var canContinue = true;
            while (canContinue)
            {
                foreach(var line in Sudoku)
                {
                    
                }
            }

            return canContinue;
        }

        public bool ForceValues(int xPos, int yPos, int val) => throw new NotImplementedException();
        public ValueTuple GetFirstUnfilledCoordinates() => throw new NotImplementedException();
        public bool Solved() => throw new NotImplementedException();
        public int?[][] SolveSudoku() => throw new NotImplementedException();
    }
}
