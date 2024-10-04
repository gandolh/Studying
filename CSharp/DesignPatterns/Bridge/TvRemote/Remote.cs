namespace DesignPatterns.Bridge.TvRemote
{
    internal class Remote
    {
        protected IDevice _device;
        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled()) _device.Disable();
            else _device.Enable();
        }

        public void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 1);
        }
        public void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 1);

        }
        public void ChannelDown()
        {
            _device.SetChanel(_device.GetChanel() - 1);
        }
        public void ChannelUp()
        {
            _device.SetChanel(_device.GetChanel() + 1);
        }
    }
}
