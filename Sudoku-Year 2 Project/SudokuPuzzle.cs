using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Year_2_Project
{
    class SudokuPuzzle
    {
        #region PROPERTIES
        int[,] _puzzleStructure = new int[9, 9];
        public int[,] PuzzleStructure 
        { 
            get { return _puzzleStructure; }
            set { _puzzleStructure = value; }
        }

        public bool Solvable { get; set;}
        #endregion

        #region CONSTRUCTORS
        // Blank constructor
        public SudokuPuzzle()
        {

        }

        public SudokuPuzzle(int[,] structure)
        {
            _puzzleStructure = structure;
        }
        #endregion
    }
}
