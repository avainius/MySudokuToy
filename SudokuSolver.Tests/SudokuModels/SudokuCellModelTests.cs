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

        [Fact]
        public void EliminatedValues_NewCellModelObjectCreated_EliminatedValuesListIsEmpty()
        {
            SudokuCellModel = new SudokuCellModel(null);

            Assert.Empty(SudokuCellModel.EliminatedValues);
        }

        [Fact]
        public void SetCellValue_CellValueIsSetToNull_CurrentCellReturnsNull()
        {
            SudokuCellModel.SetCellValue(null);

            var actualValue = SudokuCellModel.CurrentValue;

            Assert.Null(actualValue);
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelData))]
        public void SetCellValue_MethodCalledWithValidSudokuValue_CurrentCellValueIsSetToThatValue(int value)
        {
            var expectedValue = value;

            SudokuCellModel.SetCellValue(value);

            var actualValue = SudokuCellModel.CurrentValue;

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelInvalidValueData))]
        public void SetCellValue_MethodCalledWithInalidSudokuValue_ExceptionIsThrown(int value)
        {
            Assert.Throws<ArgumentException>(() => SudokuCellModel.SetCellValue(value));
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelData))]
        public void EliminateValue_TriesToElminateValidValues_EliminatedValuesListContainsThatValue(int value)
        {
            var expectedValue = value;

            SudokuCellModel.EliminateValue(value);

            Assert.Contains(expectedValue, SudokuCellModel.EliminatedValues);
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelInvalidValueData))]
        public void EliminateValue_TriesToElminateInvalidValues_ExceptionIsThrown(int value)
        {
            Assert.Throws<ArgumentException>(() => SudokuCellModel.EliminateValue(value));
        }

        [Fact]
        public void ClearEliminatedList_MethodIsCalledOnFullEliminatedValuesList_EliminatedValuesListIsEmpty()
        {
            ValidCellValues.ForEach(SudokuCellModel.EliminateValue);

            SudokuCellModel.ClearEliminatedList();

            Assert.Empty(SudokuCellModel.EliminatedValues);
        }

        [Theory]
        [ClassData(typeof(SudokuCellModelData))]
        public void ClearCellValue_TriesToClearValueFromCurrentCellValue_ValueSuccessfullyCleared(int value)
        {
            SudokuCellModel.SetCellValue(value);
            var expectedValue = value;
            var actualValue = SudokuCellModel.CurrentValue;
            Assert.Equal(expectedValue, actualValue);

            SudokuCellModel.ClearCellValue();
            Assert.Null(SudokuCellModel.CurrentValue);
        }
    }
}
