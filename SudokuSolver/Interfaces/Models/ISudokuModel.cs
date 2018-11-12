namespace SudokuSolver.Interfaces.Models
{
    public interface ISudokuModel
    {
        ISudokuBlockModel[][] Sudoku { get; }
        bool Solved { get; }
        bool NoEmptyValues();
        bool NoSoleValueViolations();
    }
}
