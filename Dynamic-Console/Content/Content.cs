using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal class Content
    {

        private int _width = 0;

        internal virtual void Display() { }

        internal virtual int GetWidth()
        {
            return _width;
        }
    }
}
