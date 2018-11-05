using SudokuSolver.Interfaces;
using SudokuSolver.Services;
using SudokuSolver.Tests.Data;
using System;
using Xunit;

namespace SudokuSolver.Tests
{
    public class SudokuSolverTests
    {
        private ISudokuSolver sudokuSolver;

        public SudokuSolverTests()
        {
            sudokuSolver = new SudokuSolverService();
        }
        
        [Theory]
        [ClassData(typeof(SudokuData))]
        public void Sudoku_TriesToSolveASudokuPuzzle_ReturnsASolvedPuzzle(int?[][] puzzle, int?[][] expectedSolution)
        {
            sudokuSolver.Sudoku = puzzle;
            var actualSolution = sudokuSolver.SolveSudoku();

            AssertEqualSudoku(expectedSolution, actualSolution);
        }

        private void AssertEqualSudoku(int?[][] expectedSolution, int?[][] actualSudoku)
        {
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    Assert.Equal(expectedSolution[i][j], actualSudoku[i][j]);
                }
            }
        }
    }
}
