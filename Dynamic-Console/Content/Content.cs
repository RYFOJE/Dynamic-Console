using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public class Content
    {

        [JsonInclude]
        [JsonPropertyName("contentWidth")]
        private int _width = 0;

        internal virtual void Display() { }

        internal virtual int GetWidth()
        {
            return _width;
        }
    }
}
