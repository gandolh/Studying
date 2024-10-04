namespace DesignPatterns.Mediator
{
    internal class MediatorMain
    {
        public MediatorMain(){}

        public void Main()
        {
            AuthenticationDialog dialog = new AuthenticationDialog();
            dialog.RunTest();
            
        }

    }
}
