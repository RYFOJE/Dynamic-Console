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

            menu.DisplayPage("page1");

        }
    }
}
