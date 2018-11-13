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
