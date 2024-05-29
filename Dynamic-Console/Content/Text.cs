using System.Text.Json.Serialization;

namespace Dynamic_Console
{
    
    public class Text : Content
    {

        private String _text = "";

        internal Text(string text)
        {
            _text = text;
        }

        internal void SetText(string text)
        {
            _text = text;
        }

        internal override void Display()
        {
            Console.Write(_text);
        }

        internal override int GetWidth()
        {
            return _text.Length;
        }

    }
}
