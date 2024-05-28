using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{

    [JsonDerivedType(typeof(RatioArrayContainer), typeDiscriminator: "RatioArrayContainer")]
    [JsonDerivedType(typeof(UniformArrayContainer), typeDiscriminator: "UniformArrayContainer")]
    [JsonDerivedType(typeof(LeftPaddedContainer), typeDiscriminator: "LeftPaddedContainer")]
    [JsonDerivedType(typeof(CenteredPaddedContainer), typeDiscriminator: "CenteredPaddedContainer")]
    [JsonDerivedType(typeof(RightPaddedContainer), typeDiscriminator: "RightPaddedContainer")]
    internal class Container
    {

        [JsonInclude]
        [JsonPropertyName("containerWidth")]
        protected int _width = 0;

        internal void SetWidth(int width)
        {
            _width = width;
        }

        internal int GetWidth()
        {
            return _width;
        }

        internal virtual void Display()
        {
            Helper.PrintChar(_width, ' ');
        }

    }
}