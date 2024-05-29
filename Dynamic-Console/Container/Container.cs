using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{

    public class Container
    {

        protected int _width = 0;

        internal void SetWidth(int width)
        {
            _width = width;
        }

        internal int GetWidth()
        {
            return _width;
        }

        internal virtual void Display()
        {
            Helper.PrintChar(_width, ' ');
        }

    }
}