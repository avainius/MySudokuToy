using System.Collections.Generic;

namespace SudokuSolver.Interfaces.Models
{
    public interface ISudokuBlockModel
    {
        ISudokuCellModel[][] Block { get; }
        List<ISudokuCellModel> CellList { get; }
        void ValidateBlock(int?[][] sudoku);
        void MarkDublicateCells();
        void MarkIntersectingCells(List<ISudokuCellModel> cells);
        void RemoveMark(ISudokuCellModel cell);
        void RemoveAllMarks();
        bool BlockHasDublicates();
        bool HasIntersectingCells(List<ISudokuBlockModel> blocks);
    }
}
