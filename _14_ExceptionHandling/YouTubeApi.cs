using Shared;

namespace _14_ExceptionHandling
{
	public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
			try
			{
				//access youtube web servie
				//read the data
				//create a list of Video objects
				throw new Exception("Oops some low level Youtube error.");
			}
			catch (Exception ex)
			{
				//Log
				throw new YoutubeException("Could not fetch the videos from the Youtube. ",ex);
			}
			return new List<Video>();
        }
    }
}
