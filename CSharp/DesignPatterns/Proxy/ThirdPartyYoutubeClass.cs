
namespace DesignPatterns.Proxy
{
    internal class ThirdPartyYoutubeClass : IThirdPartyYoutubeLib
    {
        public async Task<string> DownloadVideo(int id)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return "video for download";
        }

        public async Task<string> GetVideoInfo(int id)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return "video info";
        }

        public async Task<List<string>> ListVideos()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return new List<string>()
            {
                "video 1",
                "video 2",
                "video 3"
            };
        }
    }
}
