using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class Cell
    {
        public bool Flag 
        { get; set; }
        public bool Mine
        { get; set; }
        public bool Hidden //true is clicked false is hidden (starts false)
        { get; set; }
        public String Display
        { get; set; }
        

        public Cell()
        {
            Flag = false;
            Mine = false;
            Hidden = false;
            Display = " "; //the character that is displayed to the user to resemble the piece
        }
    }
}
