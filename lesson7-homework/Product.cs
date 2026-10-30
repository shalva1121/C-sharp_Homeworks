using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_homework
{
    internal class Product
    {
        public int Id;
        public string Name;
        public decimal Price;
        public bool Nuts;
        public string Image;
        public bool Vegetarian;
        public int Spiciness;
        public string Category;


        public void Print()
        {
            Console.WriteLine("product info:");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: { Name}");
            Console.WriteLine($"Price: {Price}₾");
            Console.WriteLine($"Nuts: {Nutss(Nuts)}");
            Console.WriteLine($"image: {Image}");
            Console.WriteLine($"Vegetarian: {Veg( Vegetarian)}");
            Console.WriteLine($"Spiciness: {Spiciness}");
            Console.WriteLine($"Category: { Category}");
        }
        public  decimal Getcurrrancy(decimal x)
        {
            return x*2.6m  ;
        }
        public string Veg(bool x)
        {
            return x?"this product is not vegeterian": "this product is vegeterian";
        }
        public string Nutss(bool x)
        {
            return x ? "this product does have Nuts" : "this product doesn't have Nuts";
        }
    }
}
