using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine("What is your name?");
            customer._name = Console.ReadLine();
            Console.WriteLine("What item do you want?");
            var product = new Product();
            product._productTyp = Console.ReadLine();

        }
    }
}
