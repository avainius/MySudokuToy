namespace SudokuSolver.Interfaces.Services.Base
{
    public interface ISolveMethodBase
    {
        void Solve(int x, int y);
        bool CanSolve(int x, int y);
    }
}
