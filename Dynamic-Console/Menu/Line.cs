﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal class Line
    {

        private Container _container;

        internal Line() 
        {
            SetContainer(new Container());
        }

        internal Line(Container container)
        {
            SetContainer(container);
        }

        internal void SetContainer(Container newContainer)
        {
            _container = newContainer;
            newContainer.SetWidth(Menu.GetWidth());
        }

        internal void Display()
        {
            Console.Write(Helper.borderCharacters["VERTICAL"]);
            _container.Display();
            Console.WriteLine(Helper.borderCharacters["VERTICAL"]);
        }

    }
}
