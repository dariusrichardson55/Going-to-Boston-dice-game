using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    class Console
    {
        static public string Ask(string answer)
        {
            System.Console.Write(answer);
            return System.Console.ReadLine();
        }


    }
}
