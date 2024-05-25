using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal abstract class SingleContainer : Container
    {

        protected Content _content = new Content();

        internal SingleContainer(Content content)
        {
            SetContent(content);
        }

        internal void SetContent(Content newContent)
        {
            _content = newContent;
        }

        internal abstract override void Display();

    }
}
