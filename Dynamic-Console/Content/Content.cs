using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class Content
    {

        private int _width = 0;

        public virtual void Display() { }

        public virtual int GetWidth()
        {
            return _width;
        }
    }
}
