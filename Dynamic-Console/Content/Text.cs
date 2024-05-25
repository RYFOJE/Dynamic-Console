namespace Dynamic_Console
{
    public class Text : Content
    {

        private String _text = "";

        public Text(string text)
        {
            _text = text;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public override void Display()
        {
            Console.Write(_text);
        }

        public override int GetWidth()
        {
            return _text.Length;
        }

    }
}
