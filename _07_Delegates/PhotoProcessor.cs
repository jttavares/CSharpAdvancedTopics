// See https://aka.ms/new-console-template for more information


public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);

    public PhotoProcessor()
    {
    }
    public void Process(string path, Action<Photo> filterHandler)
    {
       
        var photo = new Photo();

        var filters = new PhotoFilters();

        //filters.ApplyBrightness(photo);
        //filters.ApplyContrast(photo);
        //filters.Resize(photo);

        filterHandler(photo);

        photo.Save();
    }
}