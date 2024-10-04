using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.Game
{
    internal class OrcsAi : GameAi
    {
        //Scouts
        private List<string> Scouts = new List<string>();
        // Warriors
        private List<string> Warriors = new List<string>();


        protected override void BuildStructures()
        {
            Console.WriteLine("no building for orcs");
        }

        protected override void BuildUnits()
        {
            Console.WriteLine("Recruiting orc units");
            if (Scouts.Count > Warriors.Count)
                Warriors.Add($"orc warrior {Warriors.Count + 1}");
            else Scouts.Add($"orc scout {Scouts.Count + 1}");

        }

        protected override void SendScouts(int position)
        {
            Console.WriteLine("### Start send scouts ###");
            foreach (string scout in Scouts)
            {
                Console.WriteLine("Sent {0} at position {1}", scout, position);
            }
        }

        protected override void SendWarriors(int position)
        {
            Console.WriteLine("### Start send warriors ###");
            foreach (string warrior in Warriors)
            {
                Console.WriteLine("Sent {0} at position {1}", warrior, position);
            }
        }
    }
}
