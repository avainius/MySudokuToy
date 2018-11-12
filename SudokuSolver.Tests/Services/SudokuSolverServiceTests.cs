using SudokuSolver.Interfaces.Services;
using SudokuSolver.Services;
using SudokuSolver.Tests.Data.Services;
using Xunit;

namespace SudokuSolver.Tests
{
    public class SudokuSolverServiceTests
    {
        private ISudokuSolverService sudokuSolver;

        public SudokuSolverServiceTests()
        {
            sudokuSolver = new SudokuSolverService();
        }
        
        [Theory]
        [ClassData(typeof(ProblemSolutionEasySudokuSolverServiceData))]
        public void Sudoku_TriesToSolveASudokuPuzzle_ReturnsASolvedPuzzle(int?[][] puzzle, int?[][] expectedSolution)
        {
            sudokuSolver.Sudoku = puzzle;
            var actualSolution = sudokuSolver.SolveSudoku();

            AssertEqualSudoku(expectedSolution, actualSolution);
        }

        [Theory]
        [ClassData(typeof(ProblemSolutionEasySudokuSolverServiceData))]
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
