using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dynamic_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = Menu.GetInstance();
            Page page1 = new Page(4);
            menu.AddPage("page1", page1);

            page1.GetSection(0).EnableDivider();
            page1.GetSection(0).AddLine(new Line(new CenteredPaddedContainer(new Text("ANNIVERSARY MINDER ~ ALL Anniversaries"))));

            page1.GetSection(1).EnableDivider();

            RatioArrayContainer headers = new RatioArrayContainer();
            headers.AddContainer(new LeftPaddedContainer(new Text("Name(s)")), 0.6f);
            headers.AddContainer(new LeftPaddedContainer(new Text("Date")), 0.2f);
            headers.AddContainer(new LeftPaddedContainer(new Text("Type")), 0.2f);

            page1.GetSection(1).AddLine(new Line(headers));

            page1.GetSection(2).EnableDivider();
            page1.GetSection(2).AddLine(new Line(new LeftPaddedContainer(new Text("There are currently no saved anniversaries"))));

            page1.GetSection(3).AddLine(new Line(new LeftPaddedContainer(new Text("Press # from the above list to select an entry."))));
            page1.GetSection(3).AddLine(new Line(new LeftPaddedContainer(new Text("Press N to add a new anniversary."))));
            page1.GetSection(3).AddLine(new Line(new LeftPaddedContainer(new Text("Press U to list upcoming anniversaries."))));
            page1.GetSection(3).AddLine(new Line(new LeftPaddedContainer(new Text("Press X to quit."))));
            menu.DisplayPage("page1");


            //string jsonString = File.ReadAllText("JSON/layout.json");
            //menu = JsonSerializer.Deserialize<Menu>(jsonString);

            //string jsonString = JsonSerializer.Serialize(menu);

            //Console.WriteLine(jsonString);


        }
    }
}
