namespace DesignPatterns.Bridge.TvRemote
{
    internal class Radio : IDevice
    {
        private bool _enabled = false;
        private int _channel = 0;
        private int _volume;

        public void Disable()
        {
            _enabled = false;
        }

        public void Enable()
        {
            _enabled = true;

        }

        public int GetChanel()
        {
            return _channel;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public bool IsEnabled()
        {
            return _enabled;
        }

        public void SetChanel(int channel)
        {
            _channel = channel;
        }

        public void SetVolume(int percent)
        {
            _volume = percent;
        }

        public override string ToString()
        {
            return $"RADIO Details:\n" +
                   $"Enabled: {_enabled}\n" +
                   $"Channel: {_channel}\n" +
                   $"Volume: {_volume}";
        }
    }
}
