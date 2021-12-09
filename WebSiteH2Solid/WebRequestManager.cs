using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WebSiteH2Solid
{
    class WebRequestManager : IReader
    {
        WebRequest request;
        WebResponse response;
        string Url;
        public WebRequestManager(string url)
        {
            Url = url;
        }
        public string Read()
        {
            RecieveData();
            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                return responseFromServer;
            }
        }
        public void RecieveData()
        {
            UrlRequest();
            GetResponse();
        }
        private void UrlRequest()
        {
            request = WebRequest.Create(
              $"https://{Url}");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
        }
        private void GetResponse()
        {
            response = request.GetResponse();
        }
    }
}
