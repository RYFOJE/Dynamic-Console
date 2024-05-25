using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console.Menu
{
    public class Page
    {

        public Section[] _sections;

        public Page()
        {
            _sections = new Section[1];
            _sections[0] = new Section();
        }

        public Page(int sectionCount)
        {
            if (sectionCount < 1) { throw new ArgumentOutOfRangeException("A page must have 1 section or more"); }

            _sections = new Section[sectionCount];

            for(int i = 0; i < sectionCount; i++)
            {
                _sections[i] = new Section();
            }
        }

        public void Display()
        {
            foreach (var item in _sections)
            {
                item.Display();
            }
        }

    }
}
