using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZHook.Handler
{
    public static class Writer
    {
        public static void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"                                             ____  ____  _  _   __    __  __ _ ");
            Console.WriteLine(@"                                            (  __)(__  )/ )( \ /  \  /  \(  / )");
            Console.WriteLine(@"                                             ) _)  / _/ ) __ ((  O )(  O ))  ( ");
            Console.WriteLine(@"                                            (____)(____)\_)(_/ \__/  \__/(__\_)");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
