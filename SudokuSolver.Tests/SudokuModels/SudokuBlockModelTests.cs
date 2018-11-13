using SudokuSolver.Interfaces.Models;
using SudokuSolver.SudokuModels;
using SudokuSolver.Tests.Data.SudokuModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SudokuSolver.Tests.SudokuModels
{
    public class SudokuBlockModelTests
    {
        ISudokuBlockModel SudokuBlockModel;
        (int X, int Y) BlockDimensions = (3, 3);

        public SudokuBlockModelTests()
        {
            SudokuBlockModel = new SudokuBlockModel(null);
        }

        [Theory]
        [ClassData(typeof(SudokuBlockModelValidData))]
        public void Block_NewBlockModelCreated_BlockFitsDimensions(int?[][] sudoku)
        {
            SudokuBlockModel = new SudokuBlockModel(sudoku);
            var expectedLineLength = BlockDimensions.X;
            var expectedLineCount = 3;

            var actualLineCount = SudokuBlockModel.Block.Length;

            Assert.Equal(expectedLineCount, actualLineCount);
            foreach(var line in SudokuBlockModel.Block)
            {
                var actualLineLength = line.Length;
                Assert.Equal(expectedLineLength, actualLineLength);
            }
        }

        [Theory]
        [ClassData(typeof(SudokuBlockModelValidData))]
        public void Block_NewSudokuBlockModelCreatedWithValidData_BlockContainsExpectedValues(int?[][] sudoku)
        {
            SudokuBlockModel = new SudokuBlockModel(sudoku);

            for(var x = 0; x < BlockDimensions.X; x++)
                for(var y = 0; y < BlockDimensions.Y; y++)
                {
                    var expectedValue = sudoku[x][y];
                    var actualValue = SudokuBlockModel.Block[x][y].CurrentValue;

                    Assert.Equal(expectedValue, actualValue);
                }
        }

        [Fact]
        public void Block_NewSudokuBlockModelCreatedWithNull_BlockWithNullValuesCreated()
        {
            SudokuBlockModel = new SudokuBlockModel(null);

            for (var x = 0; x < BlockDimensions.X; x++)
                for (var y = 0; y < BlockDimensions.Y; y++)
                {
                    var actualValue = SudokuBlockModel.Block[x][y].CurrentValue;

                    Assert.Null(actualValue);
                }
        }

        [Theory]
        [ClassData(typeof(SudokuBlockModelInvalidData))]
        public void ValidateBlock_NewSudokuBlockModelCreatedWithInvalidData_ArgumentExceptionIsThrown(int?[][] sudoku)
        {
            Assert.Throws<ArgumentException>(() => SudokuBlockModel.ValidateBlock(sudoku));
        }

        [Theory]
        [ClassData(typeof(SudokuBlockModelInvalidData))]
        public void ValidateBlock_NewSudokuBlockModelCreatedWithInvalidData_ArgumentExceptionIsThrownFromConstructor(int?[][] sudoku)
        {
            Assert.Throws<ArgumentException>(() => SudokuBlockModel = new SudokuBlockModel(sudoku));
        }

        [Theory]
        [ClassData(typeof(SudokuBlockModelValidData))]
        public void CellList_NewSudokuBlockModelCreatedWithValidData_CellListReturnsAllCellsInList(int?[][] sudoku)
        {
            var expectedListCount = 9;
            SudokuBlockModel = new SudokuBlockModel(sudoku);

            var actualListCount = SudokuBlockModel.CellList.Count;
            Assert.Equal(expectedListCount, actualListCount);

            var expectedSequence = sudoku[0].Concat(sudoku[1]).Concat(sudoku[2]).ToList();

            for (var i = 0; i < 9; i++)
            {
                var actualValue = SudokuBlockModel.CellList[i].CurrentValue;
                var expectedValue = expectedSequence[i];
                Assert.Equal(expectedValue, actualValue);
            }
        }

        [Theory]
        [ClassData(typeof(SudokuBlockModelDublicateData))]
        public void MarkDublicateCells_NewSudokuBlockModelCreatedWithDublicates_MarksDublicateValuesInBlock(int?[][] sudoku)
        {
            SudokuBlockModel = new SudokuBlockModel(sudoku);
            var sudokuValueList = sudoku[0].Concat(sudoku[1]).Concat(sudoku[2]).ToList();
            var expectedDublicates = sudokuValueList.Where(x => sudokuValueList.Where(c => c == x).Count() > 1).Distinct();

            foreach (var cell in SudokuBlockModel.CellList)
                Assert.False(cell.Marked);

            SudokuBlockModel.MarkDublicateCells();

            foreach(var cell in SudokuBlockModel.CellList)
            {
                if (expectedDublicates.Contains(cell.CurrentValue))
                    Assert.True(cell.Marked);
                else
                    Assert.False(cell.Marked);
            }
        }
    }
}
