using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Console.Builder
{
    internal class RatioLineBuilder
    {

        private RatioArrayContainer _container;

        public RatioLineBuilder CreateRatioLine()
        {
            _container = new RatioArrayContainer();
            return this;
        }

        public RatioLineBuilder AddText(string text, float ratio)
        {
            return AddText(text, "left", ratio);
        }

        public RatioLineBuilder AddText(string text, string alignment, float ratio)
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

            _container.AddContainer(newContainer, ratio);

            return this;

        }

        public Line Build()
        {
            return new Line(_container);
        }

    }
}
