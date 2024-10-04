
namespace DesignPatterns.Facade.AcmeThirdLib
{
    internal class CodecFactory
    {
        // .... DOING FANCY STUFFS
        internal Codec Extract(VideoFile file)
        {
            return new Codec(file);
        }
    }
}
