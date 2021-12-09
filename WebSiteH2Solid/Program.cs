using System;

namespace WebSiteH2Solid
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager webmanager = new Manager(new WebRequestManager("docs.microsoft.com"));
            Console.WriteLine(webmanager.ShowContent());
            Manager filemanager = new Manager(new FileManager("testfile.txt"));
            Console.WriteLine(filemanager.ShowContent());
            Console.ReadKey();
        }
    }
}
