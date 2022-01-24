using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eZHook.Handler;

namespace eZHook.Cmd
{
    internal class Cmd
    {
        public static bool loop = true;
        public static bool debugging = false;

        public static void Main(string[] args)
        {
            Console.Title = "eZHook";
            Writer.Logo();
            Loop();
            Console.ReadLine();
        }

        public static void Loop()
        {
            try
            {
                if (loop)
                {
                    Webhook.Send("url", "username", "content");
                    if (debugging)
                    {
                        Console.WriteLine("Sent webhook");
                    }
                    Loop();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "eZHook");
            }
        }
    }
}
