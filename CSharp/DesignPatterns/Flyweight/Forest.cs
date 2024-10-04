using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace DesignPatterns.Flyweight
{
    internal class Forest
    {
        public List<Tree> trees = new List<Tree>();
        private readonly TreeFactory _treeFactory;

        public Forest()
        {
            _treeFactory = new TreeFactory();
        }

        public Tree PlantTree(int x, int y, string name, string color, string texture)
        {
            // this takes mb
            var treeType = _treeFactory.GetTreeType(name,color, texture);
            // this takes GB
            //var treeType = new TreeType(name,color,texture);
            var tree = new Tree(x, y, treeType);
            trees.Add(tree);
            return tree;
        }

        public void Draw()
        {
            foreach (var tree in trees)
            {
                tree.Draw();
                Console.WriteLine("=======================================");
            }
        }
      
    }
}
