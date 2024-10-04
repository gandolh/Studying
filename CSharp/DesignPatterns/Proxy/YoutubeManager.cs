namespace DesignPatterns.Proxy
{
    internal class YoutubeManager
    {
        private const string FormatLogDate = "########## {0} ##########";
        private const string FormatHour = "HH:mm:ss";
        IThirdPartyYoutubeLib _service;
        public YoutubeManager(IThirdPartyYoutubeLib service)
        {
            _service = service;
        }

        public async Task RenderVideoPage(int id)
        {
            string info = await _service.GetVideoInfo(id);
            Console.WriteLine(info);
        }

        public async Task RenderListPanel()
        {
            List<string> list = await _service.ListVideos();

            Console.WriteLine("List panel:");
            list.ForEach(Console.WriteLine);
        }

        public async Task ReactOnUserInput()
        {
            Console.WriteLine(FormatLogDate, DateTime.Now.ToString(FormatHour));
            await RenderVideoPage(0);
            Console.WriteLine(FormatLogDate, DateTime.Now.ToString(FormatHour));
            await RenderVideoPage(0);
            Console.WriteLine(FormatLogDate, DateTime.Now.ToString(FormatHour));
            await RenderListPanel();
            Console.WriteLine(FormatLogDate, DateTime.Now.ToString(FormatHour));
            await RenderListPanel();
            Console.WriteLine(FormatLogDate, DateTime.Now.ToString(FormatHour));
            await RenderListPanel();
            Console.WriteLine(FormatLogDate, DateTime.Now.ToString(FormatHour));
        }

    }
}
