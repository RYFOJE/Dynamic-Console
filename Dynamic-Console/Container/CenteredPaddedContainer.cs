using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class CenteredPaddedContainer : SingleContainer
    {

        public CenteredPaddedContainer(Content content) : base(content) { }

        internal override void Display()
        {
            int totalPadding = _width - _content.GetWidth();
            int leftPadding = totalPadding / 2;
            int rightPadding = totalPadding - leftPadding;

            Helper.PrintChar(leftPadding, ' ');

            _content.Display();

            Helper.PrintChar(rightPadding, ' ');
        }

    }
}
