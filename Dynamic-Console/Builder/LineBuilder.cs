using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console.Builder
{
    internal class LineBuilder
    {

        public static Line LeftPaddedLine(string text)
        {
            return new Line(new LeftPaddedContainer(new Text(text)));
        }

        public static Line CenteredPaddedLine(string text)
        {
            return new Line(new CenteredPaddedContainer(new Text(text)));
        }

        public static Line RightPaddedLine(string text)
        {
            return new Line(new RightPaddedContainer(new Text(text)));
        }

    }
}
