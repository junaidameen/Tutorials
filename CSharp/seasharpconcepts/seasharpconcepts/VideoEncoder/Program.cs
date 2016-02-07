using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.VideoEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "My Video" };
            VideoEncoder myEncoder = new VideoEncoder(); // Publisher

            var mailService = new MailService(); // Subscriber
            myEncoder.videoEncoded += mailService.OnVideoEncode;

            var messageService = new MessageService(); // Subscriber
            myEncoder.videoEncoded += messageService.OnVideoEncode;

            myEncoder.Encode(video);

            Console.ReadLine();
        }
       
    }

    
}
