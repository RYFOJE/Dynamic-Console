using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class LeftPaddedContainer : SingleContainer
    {

        public LeftPaddedContainer(Content content) : base(content) { }

        internal override void Display()
        {
            _content.Display();

            int calculatedPadding = _width - _content.GetWidth();
            Helper.PrintChar(calculatedPadding, ' ');
        }

    }
}
