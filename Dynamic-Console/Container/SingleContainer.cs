using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    abstract class SingleContainer(int width) : Container(width)
    {

        Content _content = new Content();

        public void SetContent(Content newContent)
        {
            _content = newContent;
        }

    }
}
