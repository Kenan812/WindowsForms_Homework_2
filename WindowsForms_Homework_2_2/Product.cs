using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Homework_2_2
{
    public class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }


        public Product(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public Product()
        {
            Name = "";
            Description = "";
            Price = 0;
        }

        public override string ToString()
        {
            return $"{Name} {Description} {Price}";
        }
    }
}
