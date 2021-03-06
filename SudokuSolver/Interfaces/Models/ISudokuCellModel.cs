﻿using System.Collections.Generic;

namespace SudokuSolver.Interfaces.Models
{
    public interface ISudokuCellModel
    {
        int? CurrentValue { get; }
        int? SoleCandidate { get; }
        List<int> ValidValues { get; }
        List<int> PossibleValues { get; }
        List<int> EliminatedValues { get; }
        bool Marked { get; set; }

        int? SetCellValue(int? value);
        void EliminateValue(int value);
        void ClearEliminatedList();
        void ClearCellValue();
        bool ValueValid(int value);
    }
}
