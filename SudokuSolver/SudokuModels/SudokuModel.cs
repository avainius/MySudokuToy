using SudokuSolver.Interfaces.Models;

namespace SudokuSolver.SudokuModels
{
    public class SudokuModel : ISudokuModel
    {
        public ISudokuBlockModel[][] Sudoku => throw new System.NotImplementedException();

        public bool Solved => throw new System.NotImplementedException();

        public bool NoEmptyValues() => throw new System.NotImplementedException();
        public bool NoSoleValueViolations() => throw new System.NotImplementedException();
    }
}
