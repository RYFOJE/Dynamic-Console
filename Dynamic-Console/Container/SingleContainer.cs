using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public abstract class SingleContainer : Container
    {

        protected Content _content = new Content();

        public SingleContainer(Content content)
        {
            SetContent(content);
        }

        public void SetContent(Content newContent)
        {
            _content = newContent;
        }

    }
}
