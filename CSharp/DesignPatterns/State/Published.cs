using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal class Published : IState
    {
        private Document document;
        private User _user;

        public Published(Document document, User user)
        {
            this.document = document;
            this._user = user;
        }

        public void Publish()
        {
            Console.WriteLine("republish published _document");
        }

        public void Render()
        {
            Console.WriteLine("Render published _document");
        }

        public void SetUser(User user)
        {
            _user = user;
        }   
    }
}
