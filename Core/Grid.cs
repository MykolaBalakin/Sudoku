using System;
using System.Collections.Generic;

namespace Balakin.Sudoku.Core
{
    public class Grid
    {
        public static Grid Parse(string grid)
        {
            throw new NotImplementedException();
        }

        public static Grid Parse(IReadOnlyList<string> lines)
        {
            throw new NotImplementedException();
        }

        public Cell this[int row, int column]
        {
            get { throw new NotImplementedException(); }
        }
    }
}