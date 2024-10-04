using DesignPatterns.Facade.AcmeThirdLib;

namespace DesignPatterns.Facade
{
    internal class MPEG4CompressionCodec : Codec
    {
        public MPEG4CompressionCodec()
        {
        }

        // .... DOING FANCY STUFFS
        public MPEG4CompressionCodec(VideoFile file) : base(file)
        {
        }
    }
}