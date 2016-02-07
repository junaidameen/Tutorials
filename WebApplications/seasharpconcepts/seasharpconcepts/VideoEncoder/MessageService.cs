using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.VideoEncoder
{
    class MessageService
    {
        public void OnVideoEncode(object ob, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending text message..." + args.Video.Title);
        }
    }
}
