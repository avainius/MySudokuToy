using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Tests.Data.SudokuModels
{
    public class SudokuBlockModelInvalidData : IEnumerable<object[]>
    {
        public int?[][] Sudoku1 = new int?[3][]
        {
            new int?[3]{ 10, 2, 3 },
            new int?[3]{ 4, 50, 6 },
            new int?[3]{ 7, 8, 9 }
        };

        public int?[][] Sudoku2 = new int?[3][]
        {
            new int?[3]{ 1, 0, 3 },
            new int?[3]{ 4, 5, null },
            new int?[3]{ null, 8, 9 }
        };

        public int?[][] Sudoku3 = new int?[3][]
        {
            new int?[3]{ null, -6, null },
            new int?[3]{ null, 0, null },
            new int?[3]{ -48, 9, null }
        };

        public int?[][] Sudoku4 = new int?[3][]
        {
            new int?[3]{ 1, -8, 3 },
            new int?[3]{ 4, 5, null },
            new int?[3]{ null, 8, 9 }
        };

        public int?[][] Sudoku5 = new int?[2][]
        {
            new int?[3]{ 1, -8, 3 },
            new int?[3]{ 4, 5, null }
        };

        public int?[][] Sudoku6 = new int?[4][]
        {
            new int?[3]{ 1, 2, 3 },
            new int?[3]{ 4, 5, null },
            new int?[3]{ null, 8, 9 },
            new int?[3]{ null, 6, 7 }
        };

        public int?[][] Sudoku7 = new int?[3][]
        {
            new int?[3]{ 1, 2, 3 },
            new int?[3]{ 4, 5, 6 },
            new int?[3]{ 7, 8, 1 }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Sudoku1 };
            yield return new object[] { Sudoku2 };
            yield return new object[] { Sudoku3 };
            yield return new object[] { Sudoku4 };
            yield return new object[] { Sudoku5 };
            yield return new object[] { Sudoku6 };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
