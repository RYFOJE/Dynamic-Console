using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        internal void Display()
        {
            Console.Write(Helper.borderCharacters["VERTICAL"]);
            Helper.PrintChar(Menu.GetPadding(), ' ');
            _container.Display();
            Helper.PrintChar(Menu.GetPadding(), ' ');
            Console.WriteLine(Helper.borderCharacters["VERTICAL"]);
        }

    }
}
