using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Tests.Data.SudokuModels
{
    public class SudokuBlockModelDublicateData : IEnumerable<object[]>
    {
        public int?[][] Sudoku1 = new int?[3][]
        {
            new int?[3]{ 1, 5, 3 },
            new int?[3]{ 4, 5, 6 },
            new int?[3]{ 7, 5, 9 }
        };

        public int?[][] Sudoku2 = new int?[3][]
        {
            new int?[3]{ 1, 2, 3 },
            new int?[3]{ 4, 3, 6 },
            new int?[3]{ 7, 6, 9 }
        };

        public int?[][] Sudoku3 = new int?[3][]
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
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
