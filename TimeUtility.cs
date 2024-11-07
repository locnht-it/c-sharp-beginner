using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBeginner
{
    public static class TimeUtility
    {
        public static void PrintTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}