using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class Section
    {

        private bool _isBottomDivider = false;
        private List<Line> _lines = [];

        public Section() { }

        public void EnableDivider() 
        {
            _isBottomDivider = true;
        }

        public void DisableDivider()
        {
            _isBottomDivider = false;
        }

        /// <summary>
        /// Displays the whole section
        /// </summary>
        public void Display() 
        { 
            
            foreach (var line in _lines)
            {
                line.Display();
            }

            if (_isBottomDivider)
            {
                Console.Write(Helper.borderCharacters["T_RIGHT"]);
                Helper.PrintChar(Menu.GetWidth(), Helper.borderCharacters["ACROSS"]);
                Console.WriteLine(Helper.borderCharacters["T_LEFT"]);
            }
                
        }

    }
}
