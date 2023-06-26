// See https://aka.ms/new-console-template for more information
internal class MailService
{
	public MailService()
	{

	}

    internal void Send(Mail mail)
    {
        Console.WriteLine("Email foi enviado com sucesso!");
    } 
    
    internal void Send(MessageService text)
    {
        Console.WriteLine("Email foi enviado com sucesso!");
    }

    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"MailService: Sending a email... {e.Video.Title}");
    }
}