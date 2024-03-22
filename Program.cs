using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieMasini;
namespace Inchiriere_masini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Masina m1 = new Masina("ss",2);
            Console.WriteLine(m1);
            Console.ReadLine();
        }
    }
}
