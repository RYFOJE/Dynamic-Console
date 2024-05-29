using System.Data;

namespace Dynamic_Console
{
    public class UniformArrayContainer : MultiContainer
    {

        internal void AddContainer(Container container)
        {
            _containers.Add(container);
        }

        protected override void UpdateSizing()
        {
            int widthEach = _width / _containers.Count;

            foreach (var container in _containers)
            {
                container.SetWidth(widthEach);
            }

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
