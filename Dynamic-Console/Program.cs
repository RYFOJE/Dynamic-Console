using Dynamic_Console.Builder;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Dynamic_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PageBuilder pageBuilder = new PageBuilder();
            UniformLineBuilder uniformLineBuilder = new UniformLineBuilder();
            RatioLineBuilder ratioLineBuilder = new RatioLineBuilder();

            Menu menu = Menu.GetInstance();

            Line headerLine = ratioLineBuilder.CreateRatioLine()
                .AddText("Name(s)", 0.6f)
                .AddText("Date", 0.2f)
                .AddText("Type", 0.2f)
                .Build();

            Page menuPage = pageBuilder.CreatePage(4)
                .AddDivider(0).AddDivider(1).AddDivider(2)
                .AddLine(LineBuilder.CenteredPaddedLine("ANNIVERSARY MINDER ~ ALL Anniversaries"), 0)
                .AddLine(headerLine, 1)
                .AddLine(LineBuilder.LeftPaddedLine("There are currently no saved anniversaries"), 2)
                .AddLine(LineBuilder.LeftPaddedLine("Press # from the above list to select an entry."), 3)
                .AddLine(LineBuilder.LeftPaddedLine("Press N to add a new anniversary."), 3)
                .AddLine(LineBuilder.LeftPaddedLine("Press U to list upcoming anniversaries."), 3)
                .AddLine(LineBuilder.LeftPaddedLine("Press X to quit."), 3)
                .Build();

            
            menu.AddPage("page1", menuPage);
            menu.DisplayPage("page1");

        }
    }
}
