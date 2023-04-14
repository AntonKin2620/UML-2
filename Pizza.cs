using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Pizza_Store
{
    public class Pizza
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Pizza()
        {
        
          
        }

        public Pizza(int number, string name, double price) 
        {
           Number = number;
           Name = name;
           Price = price;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        
            public override string ToString()
        {
            return $"Number: {Number}, Price: {Price}, Name: {Name}";
        }
    }
}
