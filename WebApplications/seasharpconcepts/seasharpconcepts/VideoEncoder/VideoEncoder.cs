using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.VideoEncoder
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    class VideoEncoder
    {
        // 1. Define delegate
        // 2. Define an event based on that delegate
        // 3. Raise an event.

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler videoEncoded;

        readonly int read = 10;  

        public VideoEncoder()
        {
            read = 100;
        }

        //public event EventHandler<VideoEventArgs> videoEncoded;
       

        public void Encode(Video video)
        {
           
            Console.WriteLine("Encoding vidoe... " + video.Title);
            
            System.Threading.Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected void OnVideoEncoded(Video video)
        {
            if (videoEncoded != null)
                //videoEncoded(this, new VideoEventArgs() { Video = video  });
                videoEncoded(this, new VideoEventArgs() { Video = video });

        }
        

    }

     
}
