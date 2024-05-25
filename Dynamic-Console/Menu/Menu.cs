using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console.Menu
{
    public class Menu
    {
        private Menu? _instance;
        public static int width = 75;

        /// <summary>
        /// Stores all the pages that can be displayed.
        /// </summary>
        private Dictionary<string, Page> _pages = [];

        private Menu() {}

        /// <summary>
        /// Singleton implementation to always get the same Menu
        /// </summary>
        /// <returns></returns>
        public Menu GetInstance()
        {
            if (_instance == null)
                _instance = new Menu();
            return _instance;
        }

        /// <summary>
        /// Adds a page to the Dictionary of available pages.
        /// </summary>
        /// <param name="pageName">The name of the page.</param>
        /// <param name="newPage">The new page.</param>
        public void AddPage(string pageName, Page newPage)
        {
            _pages.Add(pageName, newPage);
        }

        /// <summary>
        /// Get the page with the current name. This is useful for if you want to modify
        /// the page in question.
        /// </summary>
        /// <param name="pageName">The name of the page to fetch.</param>
        /// <returns></returns>
        public Page GetPage(string pageName)
        {
            return _pages[pageName];
        }

        /// <summary>
        /// Displays the page wanted by calling the pages Display() function.
        /// </summary>
        /// <param name="pageName">The page name to be displayed</param>
        public void DisplayPage(string pageName)
        {
            _pages[pageName].Display();
        }


    }

    public static class Helper
    {
        public static void PrintChar(int count, char character)
        {
            Console.Write(character);
        }

        public static readonly Dictionary<String, char> borderCharacters = new Dictionary<string, char>
        {
            { "TOP_LEFT", '╔' },
            { "TOP_RIGHT", '╗' },
            { "BOTTOM_LEFT", '╚' },
            { "BOTTOM_RIGHT", '╝' },
            { "ACROSS", '═' },
            { "VERTICAL", '║' },
            { "T_DOWN", '╦' },
            { "T_UP", '╩' },
            { "T_LEFT", '╣' },
            { "T_RIGHT", '╠' },
            { "CROSS", '╬' }
        };
        public static readonly Dictionary<String, ConsoleColor> colors = new Dictionary<string, ConsoleColor>
        {
            { "DEFAULT", ConsoleColor.White },
            { "HIGHLIGHT", ConsoleColor.Yellow },
            { "ERROR", ConsoleColor.Red },
            { "SUCCESS", ConsoleColor.Green }
        };
    }

}
