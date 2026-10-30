using System.Text;

namespace lesson7_homework
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Product product = new Product();
            product.Id = 1;
            product.Name = "ტორტი";
            product.Price = 100;
            product.Nuts = true;
            product.Image = "no image";
            product.Vegetarian = true ;
            product.Spiciness = 2;
            product.Category = "დესერტი";
            product.Price = product.Getcurrrancy(100);
            product.Print();
        }
    }
}
