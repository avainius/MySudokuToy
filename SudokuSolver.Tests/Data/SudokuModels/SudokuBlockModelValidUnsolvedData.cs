using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Tests.Data.SudokuModels
{
    public class SudokuBlockModelValidUnsolvedData : IEnumerable<object[]>
    {
        public int?[][] Sudoku1 = new int?[3][]
        {
            new int?[3]{ 1, 2, null },
            new int?[3]{ 4, 5, 6 },
            new int?[3]{ 7, 8, 9 }
        };

        public int?[][] Sudoku2 = new int?[3][]
        {
            new int?[3]{ 1, 7, 3 },
            new int?[3]{ 4, null, 2 },
            new int?[3]{ 6, 8, null }
        };

        public int?[][] Sudoku3 = new int?[3][]
        {
            new int?[3]{ 9, null, 7 },
            new int?[3]{ 1, 4, null },
            new int?[3]{ null, 2, 8 }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Sudoku1 };
            yield return new object[] { Sudoku2 };
            yield return new object[] { Sudoku3 };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
