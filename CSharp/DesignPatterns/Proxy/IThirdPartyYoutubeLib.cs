namespace DesignPatterns.Proxy
{
    internal interface IThirdPartyYoutubeLib
    {
        public Task<List<string>> ListVideos();
        public Task<string> GetVideoInfo(int id);
        public Task<string> DownloadVideo(int id);
    }
}
