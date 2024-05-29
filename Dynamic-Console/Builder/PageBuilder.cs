using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console.Builder
{
    internal class PageBuilder
    {

        private Page _page;

        public PageBuilder CreatePage()
        {
            _page = new Page();
            return this;
        }

        public PageBuilder CreatePage(int sections)
        {
            _page = new Page(sections);
            return this;
        }

        public PageBuilder AddDivider(int sectionNumber)
        {
            _page.GetSection(sectionNumber).EnableDivider();
            return this;
        }

        public PageBuilder AddLine(int sectionIndex, Line line)
        {
            _page.GetSection(sectionIndex).AddLine(line);
            return this;
        }

        public Page Build()
        {
            return _page;
        }
    }
}
