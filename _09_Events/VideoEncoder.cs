
// See https://aka.ms/new-console-template for more information


internal class VideoEncoder
{
    //private MailService _mailService;
    public VideoEncoder()
    {
        //_mailService = new MailService();
    }

    //1 - Define a delegate
    public delegate void VideoEncoderEventhandler(object source, VideoEventArgs args);
    
    //2- Define an event based on that dldegate
        //public event VideoEncoderEventhandler VideoEncoded;
        //USING EVENTHANDLER
            public event EventHandler<VideoEventArgs> VideoEncoded;

    //3 - raise the event



    protected virtual void OnVideoEncoded(Video video)
    {
       if(VideoEncoded != null)
        {
            VideoEncoded(this,new VideoEventArgs() { Video = video });
        }
    }

    
    
    public void Encode(Video video)
    {
        //_mailService.Send(new Mail());
        //_mailService.Send(new Text());
        Console.WriteLine("Encoding Video...");
        Thread.Sleep(3000);
        OnVideoEncoded(video);
    }

}