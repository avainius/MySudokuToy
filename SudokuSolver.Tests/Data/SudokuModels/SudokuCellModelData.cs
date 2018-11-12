using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Tests.Data.SudokuModels
{
    public class SudokuCellModelData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1 };
            yield return new object[] { 2 };
            yield return new object[] { 3 };
            yield return new object[] { 4 };
            yield return new object[] { 5 };
            yield return new object[] { 6 };
            yield return new object[] { 7 };
            yield return new object[] { 8 };
            yield return new object[] { 9 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
