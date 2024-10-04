namespace DesignPatterns.Proxy
{
    internal class ProxyMain
    {
        public ProxyMain()
        {
            
        }

        public void Main()
        {
            var lib = new ThirdPartyYoutubeClass();
            var proxy = new CachedYoutubeClass(lib);
            var youtubeManager= new YoutubeManager(proxy);
            youtubeManager.ReactOnUserInput().Wait();
        }
    }
}
