using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class Container
    {

        protected int _width;
        
        public Container()
        {
            _width = Menu.GetWidth();
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetWidth()
        {
            return _width;
        }


        public void Display() 
        {
            Helper.PrintChar(_width, ' ');
        }

    }
}
