using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBeginner
{
    public class SavingsAccount
    {
        public static double currInterestRate = 0.4;
        public static double bondRate;

        static SavingsAccount()
        {
            currInterestRate = 0.4;
        }

        public static void AddBondRate()
        {
            currInterestRate = bondRate + 0.1;
        }
    }
}