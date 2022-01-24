using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using eZHook.Handler;

namespace eZHook.Handler
{
    public static class Webhook
    {
        public static void Send(string url, string username, string content)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.UploadValues(url, new NameValueCollection
                {
                {
                    "content", content
                },
                {
                    "username", username
                }
                });
            }
            catch (WebException ex)
            {
                Console.WriteLine("");
                Console.WriteLine(ex.Message, "eZHook");
            }
        }
    }
}