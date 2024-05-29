using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dynamic_Console
{
    public abstract class SingleContainer : Container
    {

        [JsonInclude]
        [JsonPropertyName("containerContent")]
        protected Content _content = new Content();

        internal SingleContainer(Content content)
        {
            SetContent(content);
        }

        internal void SetContent(Content newContent)
        {
            _content = newContent;
        }

        internal abstract override void Display();

    }
}
