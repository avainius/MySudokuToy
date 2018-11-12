using SudokuSolver.Interfaces.Models;
using SudokuSolver.SudokuModels;
using SudokuSolver.Tests.Data.SudokuModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SudokuSolver.Tests.SudokuModels
{
    public class SudokuCellModelTests
    {
        ISudokuCellModel SudokuCellModel;
        List<int> ValidCellValues;

        public SudokuCellModelTests()
        {
            SudokuCellModel = new SudokuCellModel(null);
            ValidCellValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelData))]
        public void CurrentValue_NewModelCreatedWithValidIntParameter_CurrentValueIsSetToThatParameter(int value)
        {
            var expectedValue = value;

            SudokuCellModel = new SudokuCellModel(value);

            var actualValue = SudokuCellModel.CurrentValue;

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void CurrentValue_NewModelCreatedWithNullParameter_CurrentValueIsNull()
        {
            SudokuCellModel = new SudokuCellModel(null);

            var actualValue = SudokuCellModel.CurrentValue;

            Assert.Null(actualValue);
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelData))]
        public void SoleCandidate_ModelHasOnePossibleValueRemaining_SoleCandidateIsSetToThatValue(int value)
        {
            var expectedValue = value;

            foreach(var i in ValidCellValues) if (i != value) SudokuCellModel.EliminateValue(i);

            var actualValue = SudokuCellModel.SoleCandidate;

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void SoleCandidate_ModelHasMultiplePossibleValues_SoleCandidateIsNull()
        {
            SudokuCellModel.EliminateValue(2);
            SudokuCellModel.EliminateValue(4);
            SudokuCellModel.EliminateValue(8);

            var actualValue = SudokuCellModel.SoleCandidate;

            Assert.Null(actualValue);
        }

        [Fact]
        public void ValidValues_HasValuesPopulatedInConstructor_ContainsAllValidSudokuValues()
        {
            Assert.Equal(9, SudokuCellModel.ValidValues.Count);
            foreach (var value in ValidCellValues)
                Assert.Contains(value, SudokuCellModel.ValidValues);
        }

        [Fact]
        public void PossibleValues_EliminatedValuesListIsEmpty_PossibleValuesHasAllValidCellValues()
        {
            Assert.Equal(9, SudokuCellModel.PossibleValues.Count);
            foreach (var value in ValidCellValues)
                Assert.Contains(value, SudokuCellModel.PossibleValues);
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelData))]
        public void PossibleValues_ValueGetsEliminated_PossibleValuesNoLongerContainsThatValue(int value)
        {
            Assert.Contains(value, SudokuCellModel.PossibleValues);

            SudokuCellModel.EliminateValue(value);

            Assert.DoesNotContain(value, SudokuCellModel.PossibleValues);
        }
    }
}
