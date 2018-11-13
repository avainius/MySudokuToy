using SudokuSolver.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.SudokuModels
{
    public class SudokuBlockModel : ISudokuBlockModel
    {
        private ISudokuCellModel[][] _block;
        public ISudokuCellModel[][] Block => _block;

        public List<ISudokuCellModel> CellList => Block[0].Concat(Block[1]).Concat(Block[2]).ToList();

        public SudokuBlockModel(int?[][] sudoku)
        {
            ValidateBlock(sudoku);
            _block = new SudokuCellModel[3][];
            for (var i = 0; i < 3; i++)
            {
                _block[i] = new SudokuCellModel[3];
                for (var j = 0; j < 3; j++)
                    _block[i][j] = new SudokuCellModel(sudoku == null ? null : sudoku[i][j]);
            }
        }

        public void ValidateBlock(int?[][] sudoku)
        {
            if (sudoku == null) return;
            var sudokuLineCount = sudoku.Length;
            var valid = true;

            for (var i = 0; i < 3; i++)
            {
                if (!valid) break;
                var line = sudoku[i];
                if (line.Length != 3)
                    valid = false;

                for (var j = 0; j < 3; j++)
                {
                    if (line[j] < 1 || line[j] > 9)
                        valid = false;
                }
            }

            if (sudokuLineCount != 3 || !valid) throw new ArgumentException("Given puzzle block dimensions do not fit the range of 3x3.");
        }

        public void MarkDublicateCells() => throw new NotImplementedException();
        public void MarkIntersectingCells(List<ISudokuCellModel> cells) => throw new NotImplementedException();
        public void RemoveMark(ISudokuCellModel cell) => throw new NotImplementedException();
        public void RemoveAllMarks() => throw new NotImplementedException();
        public bool BlockHasDublicates() => throw new NotImplementedException();
        public bool HasIntersectingCells(List<ISudokuBlockModel> blocks) => throw new NotImplementedException();
    }
}
