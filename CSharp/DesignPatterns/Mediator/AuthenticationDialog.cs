
namespace DesignPatterns.Mediator
{
    internal class AuthenticationDialog : IMediator
    {
        private string _title;
        private Checkbox loginOrRegister;
        private Textbox _loginUsername;
        private Textbox _loginPassword;
        private Textbox _regUsername;
        private Textbox _regPassword;
        private Textbox _regEmail;
        private Checkbox _rememberMe;
        private Button _ok;
        private Button _cancel;

        public AuthenticationDialog()
        {
            // initialize ui components
            _title = "Authentication dialog";
            loginOrRegister = new(this);
            _loginUsername = new(this);
            _loginPassword = new(this);
            _regUsername = new(this);
            _regPassword = new(this);
            _regEmail = new(this);
            _rememberMe = new(this);
            _ok = new(this);
            _cancel = new(this);
        }

        public void Notify(Component sender, string @event)
        {
            if (sender == null || @event == string.Empty) return;

            if(sender == loginOrRegister)
            {
                _title = loginOrRegister.IsChecked() ? "Log in" : "Register";
            }else if(sender == _ok && @event == "click")
            {
                if (loginOrRegister.IsChecked())
                {
                    // do login logic
                    Console.WriteLine("Logged in");
                }
                else
                {
                    // do register logic
                    Console.WriteLine("Registered");
                }
                
            }
        }

        internal void RunTest()
        {
            Console.WriteLine("current title: {0}", _title);
            loginOrRegister.Click();
            Console.WriteLine("current title after loginOrRegister clicked: {0}", _title);
            _ok.Click();
            loginOrRegister.Click();
            Console.WriteLine("current title after loginOrRegister clicked again: {0}", _title);
            _ok.Click();

        }
    }
}
