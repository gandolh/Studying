namespace DesignPatterns.Bridge.TvRemote
{
    internal interface IDevice
    {
        public bool IsEnabled();
        public void Enable();
        public void Disable();
        public int GetVolume();
        public void SetVolume(int percent);
        public int GetChanel();
        public void SetChanel(int channel);
    }
}
