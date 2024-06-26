﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class Page
    {

        internal Section[] _sections;

        internal Page()
        {
            _sections = new Section[1];
            _sections[0] = new Section();
        }

        internal Page(int sectionCount)
        {
            if (sectionCount < 1) { throw new ArgumentOutOfRangeException("A page must have 1 section or more"); }

            _sections = new Section[sectionCount];

            for(int i = 0; i < sectionCount; i++)
            {
                _sections[i] = new Section();
            }
        }

        internal ref Section GetSection(int sectionNum)
        {
            return ref _sections[sectionNum];
        }

        internal void Display()
        {

            Console.Write(Helper.borderCharacters["TOP_LEFT"]);
            Helper.PrintChar(Menu.GetWidth() + Menu.GetPadding() * 2, Helper.borderCharacters["ACROSS"]);
            Console.WriteLine(Helper.borderCharacters["TOP_RIGHT"]);


            foreach (var item in _sections)
            {
                item.Display();
            }

            Console.Write(Helper.borderCharacters["BOTTOM_LEFT"]);
            Helper.PrintChar(Menu.GetWidth() + Menu.GetPadding() * 2, Helper.borderCharacters["ACROSS"]);
            Console.WriteLine(Helper.borderCharacters["BOTTOM_RIGHT"]);

        }

    }
}
