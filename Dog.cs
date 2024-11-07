using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBeginner
{
    public class Dog
    {
        private string _name;

        public Dog(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}