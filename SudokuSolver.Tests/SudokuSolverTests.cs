using SudokuSolver.Interfaces;
using SudokuSolver.Services;
using SudokuSolver.Tests.Data;
using System;
using Xunit;

namespace SudokuSolver.Tests
{
    public class SudokuSolverTests
    {
        private ISudokuSolverService sudokuSolver;

        public SudokuSolverTests()
        {
            sudokuSolver = new SudokuSolverService();
        }
        
        [Theory]
        [ClassData(typeof(FullEasySudokuSolutionData))]
        public void Sudoku_TriesToSolveASudokuPuzzle_ReturnsASolvedPuzzle(int?[][] puzzle, int?[][] expectedSolution)
        {
            sudokuSolver.Sudoku = puzzle;
            var actualSolution = sudokuSolver.SolveSudoku();

            AssertEqualSudoku(expectedSolution, actualSolution);
        }

        [Theory]
        [ClassData(typeof(FullEasySudokuSolutionData))]
        public void FillSingles_TriesToFillValuesWithSingleSolution_ReturnsTrueAllTheTime(int?[][] puzzle, int?[][] expectedSolution)
        {
            sudokuSolver.Sudoku = puzzle;
            var actualSolution = sudokuSolver.SolveSudoku();

            AssertEqualSudoku(expectedSolution, actualSolution);
        }

        private void AssertEqualSudoku(int?[][] expectedSolution, int?[][] actualSolution)
        {
            for (var i = 0; i < 9; i++)
            {
                AssertEqualSudokuRow(expectedSolution[i], actualSolution[i]);
            }
        }

        private void AssertEqualSudokuRow(int?[] expectedSolution, int?[] actualSolution)
        {
            for (var i = 0; i < 9; i++)
            {
                Assert.Equal(expectedSolution[i], actualSolution[i]);
            }
        }
    }
}
