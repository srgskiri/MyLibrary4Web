using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string now = DateTime.Now.ToString();

            return now;
        }
    }
}
