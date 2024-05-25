using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal class LeftPaddedContainer : SingleContainer
    {

        internal LeftPaddedContainer(Content content) : base(content) { }

        internal override void Display()
        {
            _content.Display();

            int calculatedPadding = _width - _content.GetWidth();
            Helper.PrintChar(calculatedPadding, ' ');
        }

    }
}
