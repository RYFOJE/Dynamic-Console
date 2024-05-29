using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console.Builder
{
    internal class UniformLineBuilder
    {

        private Line _line;
        private UniformArrayContainer _container;

        public UniformLineBuilder CreateUniformLine()
        {
            _line = new Line();
            _container = new UniformArrayContainer();
            return this;
        }

        public UniformLineBuilder AddText(string text)
        {
            return AddText(text, "left");
        }

        public UniformLineBuilder AddText(string text, string alignment)
        {

            Container newContainer;
            Text newText = new Text(text);

            switch (alignment)
            {
                case "left":
                    newContainer = new LeftPaddedContainer(newText);
                    break;

                case "center":
                    newContainer = new CenteredPaddedContainer(newText);
                    break;

                case "right":
                    newContainer = new RightPaddedContainer(newText);
                    break;

                default:
                    throw new ArgumentException("alignment is invalid");
            }

            _container.AddContainer(newContainer);

            return this;

        }

        public Line Build()
        {
            return new Line(_container);
        }

    }
}
