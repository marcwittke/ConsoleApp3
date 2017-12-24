using System;

namespace ConsoleApp3
{
    using System.Globalization;
    using Properties;

    class Program
    {
        static void Main(string[] args)
        {
            const string cultureString = "de"; // de-DE?
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureString);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureString);
            Resources.Culture = new CultureInfo(cultureString);
            
            Console.WriteLine(Resources.Hello);

            Console.WriteLine(Resources.ResourceManager.GetString("Hello", new CultureInfo(cultureString)));
        }
    }
}
