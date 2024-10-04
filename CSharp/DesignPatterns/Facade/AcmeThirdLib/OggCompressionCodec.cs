namespace DesignPatterns.Facade.AcmeThirdLib
{
    internal class OggCompressionCodec : Codec
    {
        // .... DOING FANCY STUFFS
        public OggCompressionCodec()
        {
        }

        public OggCompressionCodec(VideoFile file) : base(file)
        {
        }
    }
}
