using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    /// <summary>
    /// Parent class that acts as empty 
    /// </summary>
    public class Container
    {

        protected int _width = 0;

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetWidth()
        {
            return _width;
        }

        public virtual void Display() 
        {
            Helper.PrintChar(_width, ' ');
        }

    }
}
