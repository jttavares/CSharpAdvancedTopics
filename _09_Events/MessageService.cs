// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;

internal class MessageService
{
	public MessageService()
	{
	}
	public void OnVideoEncoded(object sender, VideoEventArgs e)
	{
		Console.WriteLine($"Message Service: Sending a text message... {e.Video.Title}");
	}
}