using DesignPatterns.Facade.AcmeThirdLib;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// The facade
    /// </summary>
    public class VideoConverter
    {
        public void Convert(string filename, string format)
        {
            VideoFile file = new VideoFile(filename);
            Codec sourceCodec = new CodecFactory().Extract(file);

            Codec destinationCodec;
            if (format == "mp4")
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }

            byte[] buffer = BitrateReader.Read(filename, sourceCodec);
            byte[] result = BitrateReader.Convert(buffer, destinationCodec);
            result = new AudioMixer().Fix(result);

            //return new File(result);
        }
    }

}
