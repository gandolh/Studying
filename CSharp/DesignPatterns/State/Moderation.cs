using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal class Moderation : IState
    {
        private Document _document;
        private User _user;

        public Moderation(Document document, User user)
        {
            this._document = document;
            this._user = user;
        }

        public void Publish()
        {
            if(_user.IsAdmin)
            {
                _document.ChangeState(new Published(_document, _user));
            }
            else
            {
                throw new Exception("You don't have permission to publish moderation document");

            }
        }

        public void Render()
        {
            Console.WriteLine("Render moderation document");
        }

        public void SetUser(User user)
        {
            _user = user;
        }
    }
}
