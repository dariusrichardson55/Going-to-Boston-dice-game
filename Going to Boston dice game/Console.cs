using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public static class ExtensionMethods
    {
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
    class Console
    {
        static public string Ask(string answer)
        {
            System.Console.WriteLine(answer);
            return System.Console.ReadLine();
        }

       

        static public int AskInt(string answer)
        {
            System.Console.WriteLine(answer);
            return System.Console.ReadLine().toInt();
        }


    }
}
