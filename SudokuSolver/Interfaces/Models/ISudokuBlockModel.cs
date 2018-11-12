using System.Collections.Generic;

namespace SudokuSolver.Interfaces.Models
{
    public interface ISudokuBlockModel
    {
        ISudokuCellModel[][] Block { get; }
        List<ISudokuCellModel> EmptyCells { get; }
        List<ISudokuCellModel> DublicateCells { get; }
        bool HasDublicates();
        bool BlockSolved();
    }
}
