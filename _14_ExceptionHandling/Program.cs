// See https://aka.ms/new-console-template for more information
using _14_ExceptionHandling;

ThrowYoutubeException();


//ThrowStreamReaderError();


void ThrowYoutubeException()
{
	try
	{
		var api = new YouTubeApi();
		var videos = api.GetVideos("mosh");
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message
			);
	}
}

static void ThrowStreamReaderError()
{
	//StreamReader streamreader = null;
	try
	{
		using (var streamReader = new StreamReader(@"C:\Users\tavar\OneDrive\Área de Trabalho\ScriptsToWhatsapp.txt"))
		{
			var content = streamReader.ReadToEnd();
			Console.WriteLine(content
				);
		}
		//streamreader = new StreamReader(@"C:\Users\tavar\OneDrive\Área de Trabalho\ScriptsToWhatsapp.txt");


		/*
		var calculator = new Calculator();
		var result = calculator.Divide(5, 0);
		*/


		/*
		 * var content = streamreader.ReadToEnd();
			Console.WriteLine(content);
		*/
	}
	catch (DivideByZeroException)
	{
		Console.WriteLine("You cannot divide by 0.");
	}
	catch (ArithmeticException ex)
	{

	}

	catch (Exception ex)
	{

		throw new Exception($"Sorry, an unexpected error ocurred => {ex.Message}");
	}
	/*
	finally
	{
		if (streamreader != null)
			streamreader.Dispose();
	}
	*/

}