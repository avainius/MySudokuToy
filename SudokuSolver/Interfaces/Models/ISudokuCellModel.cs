using System.Collections.Generic;

namespace SudokuSolver.Interfaces.Models
{
    public interface ISudokuCellModel
    {
        int? CurrentValue { get; }
        List<int> ValidValues { get; }
        List<int> PossibleValues { get; }
        List<int> EliminatedValues { get; }

        int? SetCellValue(int? value);
        void ClearCellValue();
    }
}
