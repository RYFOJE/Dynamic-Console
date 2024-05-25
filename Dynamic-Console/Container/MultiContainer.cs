using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal abstract class MultiContainer : Container
    {

        protected List<Container> _containers = new List<Container>();

        internal abstract void AddContainer(Container container);
        protected abstract void UpdateSizing();

        internal abstract override void Display();

        protected int GetActualWidth()
        {
            int runningCounter = 0;

            foreach (Container container in _containers)
            {
                runningCounter += container.GetWidth();
            }

            return runningCounter;
        }

    }
}
