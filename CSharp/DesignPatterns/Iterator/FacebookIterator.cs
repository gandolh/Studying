namespace DesignPatterns.IteratorPattern
{
    internal class FacebookIterator : IProfileIterator
    {
        private Facebook _facebook;
        private int _profileId;
        private int _type;
        private int _currentPosition;
        private Profile[]? _cache;

        public FacebookIterator(Facebook facebook, int profileId, int type)
        {
            _currentPosition = 0;
            _facebook = facebook;
            _profileId = profileId;
            this._type = type;
        }

        private void LazyInit()
        {
            if (_cache == null)
                _cache = _facebook.SocialGraphRequest(_profileId, _type);
        }

        public Profile GetNext()
        {
            if (HasMore())
                return _cache![_currentPosition++];
            throw new Exception("No more elements");
        }

        public bool HasMore()
        {
            LazyInit();
            return  _currentPosition < _cache!.Length;
        }
    }
}
