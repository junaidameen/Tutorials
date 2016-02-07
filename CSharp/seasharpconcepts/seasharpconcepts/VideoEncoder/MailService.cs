using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.VideoEncoder
{
    class MailService
    {
        public void OnVideoEncode(object ob, VideoEventArgs args)
        {
            Console.WriteLine("Mail Service: Sending Email..." + args.Video.Title);
        }
    }
}
