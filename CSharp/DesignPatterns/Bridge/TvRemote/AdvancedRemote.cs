namespace DesignPatterns.Bridge.TvRemote
{
    internal class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }

        public override string ToString()
        {
            return $"device: {_device}";
        }
    }
}
