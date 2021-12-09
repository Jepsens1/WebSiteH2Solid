using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebSiteH2Solid
{
    class FileManager : IReader
    {
        public string Path { get; set; }

        public FileManager(string path)
        {
            Path = path;
        }
        public string Read()
        {
            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (StreamReader reader = new StreamReader(Path))
            { // Read the content.
                string response = reader.ReadToEnd();
                // Display the content.
                return response;
            }
        }
    }
}
