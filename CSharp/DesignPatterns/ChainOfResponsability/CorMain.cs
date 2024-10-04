namespace DesignPatterns.ChainOfResponsability
{
    internal class CorMain
    {

        public void Main()
        {
            Dialog dialog = new Dialog("Budget report");
            Panel panel1 = new Panel("Panel 1");
            Panel panel2 = new Panel("Panel 2");
            Button button = new Button();

            panel2.Add(button);
            panel1.Add(panel2);
            dialog.Add(panel1);

            // walking to the root
            dialog.SetTooltipText("#1 tooltip text");
            button.ShowHelp();
            dialog.SetTooltipText(null);

            // using wiki page
            dialog.SetWikiPage("#1 wiki page");
            button.ShowHelp();
            dialog.SetWikiPage(string.Empty);

            // using tooltip on panel2
            panel1.SetTooltipText("#2 tooltip text");
            button.ShowHelp();
            panel1.SetTooltipText(null);


            // using help text
            panel1.SetHelpText("help text");
            button.ShowHelp();
            panel1.SetHelpText(string.Empty);

            //  setting tooltip for dialog and panel1.
            // stopping the search on panel1
            dialog.SetWikiPage("#1 wiki page");
            panel1.SetTooltipText("#2 tooltip text");
            button.ShowHelp();
            dialog.SetWikiPage(string.Empty);
            panel1.SetTooltipText(null);

        }
    }
}
