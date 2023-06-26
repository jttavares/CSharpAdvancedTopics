// See https://aka.ms/new-console-template for more information



var video = new Video() { Title = "Video 1" };
var videoEncoder = new VideoEncoder();
videoEncoder.Encode(video);
var mailService = new MailService();
var messageService = new MessageService();
videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
videoEncoder.Encode(video);
//A mechanism for communication between objects
//used in bilding Loosely Coupled Applications
//Helps exteneding applications
//Delegates
    //Agreement / Contract between Publisher and Subscriber
    //Determines the signature of the event handler method in Subscriber