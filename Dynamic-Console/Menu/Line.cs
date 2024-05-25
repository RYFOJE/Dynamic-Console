using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class Line
    {

        private Container _container;

        public Line() 
        {
            SetContainer(new Container());
        }

        public Line(Container container)
        {
            SetContainer(container);
        }

        public void SetContainer(Container newContainer)
        {
            _container = newContainer;
            newContainer.SetWidth(Menu.GetWidth());
        }

        public void Display()
        {
            Console.Write(Helper.borderCharacters["VERTICAL"]);
            _container.Display();
            Console.WriteLine(Helper.borderCharacters["VERTICAL"]);
        }

    }
}
