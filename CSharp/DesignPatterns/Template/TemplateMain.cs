using DesignPatterns.Template.DataMiner;
using DesignPatterns.Template.Game;

namespace DesignPatterns.Template
{
    internal class TemplateMain
    {
        public void Main()
        {
            DataMiner.DataMiner pdfMiner = new PdfDataMiner();
            DataMiner.DataMiner csvMiner = new CsvDataMiner();
            DataMiner.DataMiner docMiner = new DocDataMiner();
            pdfMiner.Mine("myPath");
            csvMiner.Mine("myPath");
            docMiner.Mine("myPath");

            GameAi monsterAi = new MonstersAi();
            GameAi orcsAi = new OrcsAi();
            Console.WriteLine("========== MONSTERS AI ==========");
            Console.WriteLine("====== First turn ======");
            monsterAi.TakeTurn();
            Console.WriteLine("====== Second turn ======");
            monsterAi.TakeTurn();
            Console.WriteLine("========== ORCS AI ==========");
            Console.WriteLine("====== First turn ======");
            orcsAi.TakeTurn();
            Console.WriteLine("====== Second turn ======");
            orcsAi.TakeTurn();
        }
    }
}
