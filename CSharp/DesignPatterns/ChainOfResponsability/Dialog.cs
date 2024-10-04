using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability
{
    internal class Dialog : Container
    {
        private string _wikiPageUrl = string.Empty;
        private string _title = string.Empty;

        public Dialog(string title)
        {
            _title = title;
        }

        public override void ShowHelp()
        {
            if (_wikiPageUrl != string.Empty)
                Console.WriteLine(_wikiPageUrl);
            else
                base.ShowHelp();
        }

        public void SetWikiPage(string wikiPageUrl) { _wikiPageUrl = wikiPageUrl;}
    }
}
