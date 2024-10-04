namespace DesignPatterns.Prototype
{
    internal class PrototypeRegistry
    {
        private Dictionary<string,IPrototype> prototypes;
        public PrototypeRegistry()
        {
            prototypes = new();
        }

        public void AddItem(string id, IPrototype prototype) { 
            prototypes.Add(id, prototype);
        }

        public IPrototype GetById(string id)
        {
             prototypes.TryGetValue(id, out IPrototype? prototype);
            if (prototype == null)
            {
                throw new Exception("Button not found");
            }
            return prototype.Clone();
        }

        public IPrototype GetByColor(string color)
        {
            foreach (var item in prototypes.Values)
            {
                if(item.GetColor() == color) 
                    return item.Clone();
            }

            throw new Exception("Button not found");
        }


    }
}
