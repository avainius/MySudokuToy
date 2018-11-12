using System.Collections;
using System.Collections.Generic;

namespace SudokuSolver.Tests.Data.Services
{
    public class ProblemSudokuSolverServiceData : IEnumerable<object[]>
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


        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Puzzle1 };
            yield return new object[] { Puzzle2 };
            yield return new object[] { Puzzle3 };
            yield return new object[] { Puzzle4 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
