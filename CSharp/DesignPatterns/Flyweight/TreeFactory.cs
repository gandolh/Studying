using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    internal class TreeFactory
    {
        public List<TreeType> TreeTypes = new();

        public TreeType GetTreeType(string name, string color, string texture)
        {
            TreeType treeType = new TreeType(name, color, texture);
            int index = TreeTypes.IndexOf(treeType);
            if(index == -1)
            {
                TreeTypes.Add(treeType);
                return treeType;
            }
            return TreeTypes[index];
        }

    }
}
