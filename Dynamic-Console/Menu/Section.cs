using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal class Section
    {

        private bool _isBottomDivider = false;

        [JsonInclude]
        [JsonPropertyName("lines")]
        private List<Line> _lines = [];

        internal Section() { }

        internal void AddLine(Line newLine)
        {
            _lines.Add(newLine);
        }

        internal void EnableDivider() 
        {
            _isBottomDivider = true;
        }

        internal void DisableDivider()
        {
            _isBottomDivider = false;
        }

        /// <summary>
        /// Displays the whole section
        /// </summary>
        internal void Display() 
        { 
            
            foreach (var line in _lines)
            {
                line.Display();
            }

            if (_isBottomDivider)
            {
                Console.Write(Helper.borderCharacters["T_RIGHT"]);
                Helper.PrintChar(Menu.GetWidth() + Menu.GetPadding() * 2, Helper.borderCharacters["ACROSS"]);
                Console.WriteLine(Helper.borderCharacters["T_LEFT"]);
            }
                
        }

    }
}
