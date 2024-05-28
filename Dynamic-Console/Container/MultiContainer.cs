using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{

    [JsonDerivedType(typeof(RatioArrayContainer), typeDiscriminator: "RatioArrayContainer")]
    [JsonDerivedType(typeof(UniformArrayContainer), typeDiscriminator: "UniformArrayContainer")]
    internal abstract class MultiContainer : Container
    {

        [JsonInclude]
        [JsonPropertyName("containers")]
        protected List<Container> _containers = new List<Container>();
        
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
