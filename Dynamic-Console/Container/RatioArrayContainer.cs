using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    internal class RatioArrayContainer : MultiContainer
    {

        private List<float> _ratios = new List<float>();

        protected override void UpdateSizing()
        {
            for (int i = 0; i < _containers.Count; i++)
            {
                _containers[i].SetWidth((int)(_width * _ratios[i]));
            }
        }

        internal void AddContainer(Container newContainer, float ratio)
        {
            _containers.Add(newContainer);
            _ratios.Add(ratio);
        }

        internal override void Display()
        {
            UpdateSizing();

            foreach (var container in _containers)
            {
                container.Display();
            }

            int remainingPadding = _width - GetActualWidth();

            Helper.PrintChar(remainingPadding, ' ');

        }
    }
}
