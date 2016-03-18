

namespace MyLibrary4Web
{
    public class MyExoticLibrary4Web
    {
        public static string GetName()
        {

            return "Tekst van MyExoticLibrary4Web";
        }

        public static string GetAuthor()
        {
            return "Sergey Skiridov";
        }

        public static string GetWelcomeMessage()
        {
            return "Hallow, dit is een tekst uit de library";
        }

        public static string GetNow()
        {
            string now = System.DateTime.Now.ToString();

            return now;
        }
    }
}
