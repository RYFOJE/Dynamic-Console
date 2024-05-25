namespace Dynamic_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = Menu.GetInstance();
            Page page1 = new Page();

            menu.AddPage("page1", page1);
            page1.GetSection(0).EnableDivider();
            page1.GetSection(0).AddLine(new Line());
            page1.GetSection(0).AddLine(new Line());
            page1.GetSection(0).AddLine(new Line(new LeftPaddedContainer(new Text("Hello"))));
            page1.GetSection(0).AddLine(new Line(new RightPaddedContainer(new Text("Hello"))));

            menu.DisplayPage("page1");

        }
    }
}
