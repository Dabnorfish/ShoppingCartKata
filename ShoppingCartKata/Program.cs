using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartKata
{
    internal class Program
    {
        private static void Main(string[] args) 
        {
            string code;
            string codeScanned;
            Console.WriteLine("Please scan your first item, or type '9' to exit");
            codeScanned = Console.ReadLine();
            var subject = new ShoppingCart();
            subject.Scan(codeScanned);
            Console.ReadLine();

        }
    }
}
