// See https://aka.ms/new-console-template for more information
public class PhotoFilters
{
    public PhotoFilters()
    {
    }
    public void ApplyBrightness(Photo photo) {
        Console.WriteLine("Photo brightness adjusted");
    }
    public void ApplyContrast(Photo photo) {
        Console.WriteLine("Photo contrast adjusted");
    }
    public void Resize(Photo photo) {
        Console.WriteLine("Photo resized");
    }
}