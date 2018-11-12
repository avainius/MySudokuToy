using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Interfaces
{
    public interface ISolveMethodBase
    {
        void Solve(int x, int y);
        bool CanSolve(int x, int y);
    }
}
