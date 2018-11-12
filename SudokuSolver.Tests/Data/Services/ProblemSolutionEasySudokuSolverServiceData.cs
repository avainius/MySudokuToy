using System.Collections;
using System.Collections.Generic;

namespace SudokuSolver.Tests.Data.Services
{
    public class ProblemSolutionEasySudokuSolverServiceData : IEnumerable<object[]>
    {
        public int?[][] Puzzle1 = new int?[9][] {
            new int?[9] { null, null, null, 6, null, null, 8, null, null },
            new int?[9] { 9, 4, null, 8, null, null, null, null, 7 },
            new int?[9] { 2, 3, 8, null, 9, null, null, null, 6 },
            new int?[9] { null, 2, null, 3, null, null, null, 1, null },
            new int?[9] { null, null, 4, null, null, null, 2, null, null },
            new int?[9] { null, 6, null, null, null, 7, null, 4, null },
            new int?[9] { 8, null, null, null, 7, null, 9, 6, 5 },
            new int?[9] { 6, null, null, null, null, 5, null, 2, 4 },
            new int?[9] { null, null, 5, null, null, 6, null, null, null }
        };

        public int?[][] Puzzle2 = new int?[9][] {
            new int?[9] { null, null, null, 2, null, null, null, 6, null },
            new int?[9] { 2, 5, null, 3, 7, null, null, null, null },
            new int?[9] { null, 7, null, 1, null, null, 8, null, 2 },
            new int?[9] { 9, null, null, null, null, null, 7, 3, null },
            new int?[9] { null, 6, null, 5, null, 1, null, 2, null },
            new int?[9] { null, 2, 3, null, null, null, null, null, 5 },
            new int?[9] { 7, null, 8, null, null, 6, null, 1, null },
            new int?[9] { null, null, null, null, 2, 7, null, 8, 9 },
            new int?[9] { null, 9, null, null, null, 3, null, null, null }
        };

        public int?[][] Puzzle3 = new int?[9][] {
            new int?[9] { null, null, 5, null, 2, null, 4, null, 1 },
            new int?[9] { 1, null, null, 7, 6, 5, null, null, null },
            new int?[9] { null, 7, null, null, null, null, null, null, 2 },
            new int?[9] { null, null, 4, null, null, 2, null, 1, null },
            new int?[9] { 3, 9, null, null, 4, null, null, 5, 6 },
            new int?[9] { null, 2, null, 1, null, null, 3, null, null },
            new int?[9] { 5, null, null, null, null, null, null, 2, null },
            new int?[9] { null, null, null, 5, 9, 8, null, null, 4 },
            new int?[9] { 4, null, 7, null, 1, null, 6, null, null }
        };

        public int?[][] Puzzle4 = new int?[9][] {
            new int?[9] { null, 5, null, null, 9, null, null, 3, null },
            new int?[9] { null, null, null, null, 5, 7, null, 4, null },
            new int?[9] { 6, null, null, 3, null, null, null, 1, 9 },
            new int?[9] { 2, null, null, 6, null, 1, null, null, null },
            new int?[9] { 7, 1, null, null, null, null, null, 6, 5 },
            new int?[9] { null, null, null, 5, null, 8, null, null, 7 },
            new int?[9] { 9, 7, null, null, null, 3, null, null, 1 },
            new int?[9] { null, 4, null, 9, 1, null, null, null, null },
            new int?[9] { null, 6, null, null, 8, null, null, 9, null }
        };

        public int?[][] Solution1 = new int?[9][] {
            new int?[9] { 7, 5, 1, 6, 3, 4, 8, 9, 2 },
            new int?[9] { 9, 4, 6, 8, 5, 2, 1, 3, 7 },
            new int?[9] { 2, 3, 8, 7, 9, 1, 4, 5, 6 },
            new int?[9] { 5, 2, 7, 3, 4, 8, 6, 1, 9 },
            new int?[9] { 1, 8, 4, 5, 6, 9, 2, 7, 3 },
            new int?[9] { 3, 6, 9, 2, 1, 7, 5, 4, 8 },
            new int?[9] { 8, 1, 2, 4, 7, 3, 9, 6, 5 },
            new int?[9] { 6, 9, 3, 1, 8, 5, 7, 2, 4 },
            new int?[9] { 4, 7, 5, 9, 2, 6, 3, 8, 1 }
        };

        public int?[][] Solution2 = new int?[9][] {
            new int?[9] { 8, 1, 4, 2, 9, 5, 3, 6, 7 },
            new int?[9] { 2, 5, 6, 3, 7, 8, 1, 9, 4 },
            new int?[9] { 3, 7, 9, 1, 6, 4, 8, 5, 2 },
            new int?[9] { 9, 8, 5, 6, 4, 2, 7, 3, 1 },
            new int?[9] { 4, 6, 7, 5, 3, 1, 9, 2, 8 },
            new int?[9] { 1, 2, 3, 7, 8, 9, 6, 4, 5 },
            new int?[9] { 7, 4, 8, 9, 5, 6, 2, 1, 3 },
            new int?[9] { 6, 3, 1, 4, 2, 7, 5, 8, 9 },
            new int?[9] { 5, 9, 2, 8, 1, 3, 4, 7, 6 },
        };

        public int?[][] Solution3 = new int?[9][] {
            new int?[9] { 8, 6, 5, 3, 2, 9, 4, 7, 1 },
            new int?[9] { 1, 4, 2, 7, 6, 5, 9, 8, 3 },
            new int?[9] { 9, 7, 3, 4, 8, 1, 5, 6, 2 },
            new int?[9] { 6, 5, 4, 9, 3, 2, 8, 1, 7 },
            new int?[9] { 3, 9, 1, 8, 4, 7, 2, 5, 6 },
            new int?[9] { 7, 2, 8, 1, 5, 6, 3, 4, 9 },
            new int?[9] { 5, 3, 9, 6, 7, 4, 1, 2, 8 },
            new int?[9] { 2, 1, 6, 5, 9, 8, 7, 3, 4 },
            new int?[9] { 4, 8, 7, 2, 1, 3, 6, 9, 5 }
        };

        public int?[][] Solution4 = new int?[9][] {
            new int?[9] { 1, 5, 4, 8, 9, 6, 7, 3, 2 },
            new int?[9] { 3, 2, 9, 1, 5, 7, 6, 4, 8 },
            new int?[9] { 6, 8, 7, 3, 2, 4, 5, 1, 9 },
            new int?[9] { 2, 3, 5, 6, 7, 1, 9, 8, 4 },
            new int?[9] { 7, 1, 8, 2, 4, 9, 3, 6, 5 },
            new int?[9] { 4, 9, 6, 5, 3, 8, 1, 2, 7 },
            new int?[9] { 9, 7, 2, 4, 6, 3, 8, 5, 1 },
            new int?[9] { 8, 4, 3, 9, 1, 5, 2, 7, 6 },
            new int?[9] { 5, 6, 1, 7, 8, 2, 4, 9, 3 }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Puzzle1, Solution1 };
            yield return new object[] { Puzzle2, Solution2 };
            yield return new object[] { Puzzle3, Solution3 };
            yield return new object[] { Puzzle4, Solution4 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
