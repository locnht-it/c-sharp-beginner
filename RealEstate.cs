using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBeginner
{
    public class RealEstate
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }
        public int CalculatePricePerSquareFoot() => Price / SquareFootage;
    }
}