using System;
using System.Net;
using static System.Console;

namespace csharpFundamentals
{
    public class checkUrlOnline
    {

        public static void checkUrl(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Timeout = 3000;
                request.AllowAutoRedirect = false; // find out if this site is up and don't follow a redirector
                request.Method = "HEAD";

                using (var response = request.GetResponse())
                {
                    WriteLine("Online");
                }
            }
            catch (Exception e)
            {
                WriteLine("Not Online");
            }
        }

    }
}