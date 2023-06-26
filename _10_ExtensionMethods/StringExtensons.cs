// See https://aka.ms/new-console-template for more information
//Allow us to add methods to an exisiting class without
//changing its source code
//creating a new class that inherits from it

namespace System
{
    public static class StringExtensons
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWord shpould be greater than or equal 0");
            if (numberOfWords == 0)
            {
                return "";
            }
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
            {
                return str;
            }
            return string.Join(" ", words.Take(numberOfWords));
        }
    }

}