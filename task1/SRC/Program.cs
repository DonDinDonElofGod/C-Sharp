using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._1._1
{
    class MyClass        
    {
                
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int nb = Console.Read();
            int Base = 2;                       
            var q = Convert.ToString(nb, Base);            
            Console.WriteLine($"Результат перевода в двоичную СС: {q}");
            
            Console.ReadKey();


        }       
    }
}
