using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Tests.Data.SudokuModels
{
    public class SudokuCellModelInvalidValueData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 0 };
            yield return new object[] { 10 };
            yield return new object[] { 11 };
            yield return new object[] { 500 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
