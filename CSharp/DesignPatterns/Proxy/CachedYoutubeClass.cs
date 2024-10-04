
namespace DesignPatterns.Proxy
{
    internal class CachedYoutubeClass : IThirdPartyYoutubeLib
    {
        private IThirdPartyYoutubeLib _service;
        private List<string>? _listCache;
        private string? _videoCache;

        public CachedYoutubeClass(IThirdPartyYoutubeLib service)
        {
            _service = service;
        }

        public async Task<string> DownloadVideo(int id)
        {
            return await  _service.DownloadVideo(id);
        }

        public async Task<string> GetVideoInfo(int id)
        {
            if (_videoCache == null)
            {
                _videoCache = await _service.GetVideoInfo(id);
            }
            return _videoCache;
        }

        public async Task<List<string>> ListVideos()
        {
            if (_listCache == null)
            {
                _listCache = await _service.ListVideos();
            }
            return _listCache;
        }
    }
}
