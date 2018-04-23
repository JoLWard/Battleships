using Battleships.ENum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Battleships.Models
{
    public class Cell
    {
        // Name will be A4, B2
        public string Name { get; set; }
        
        // Status will use the Enum and can set the status when a cell is interacted with
        public CellStatus Status { get; set; }
        
        // Row number 1 - 10
        public int RowNumber { get; set; }
        
        // Column A to J
        public string Column { get; set; }
    }
}
