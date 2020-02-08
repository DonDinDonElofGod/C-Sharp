using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string i = (Console.ReadLine());
            Console.WriteLine("Введите вторую строку:");
            string a = (Console.ReadLine());
            int z = 0;
            for (int o = 0; o < a.Length; o++)
            {
            if (a[o] == '*')
                {
                    z++;
                }
            }            
            bool u = String.Equals(i, a);                       
            if (u == true || z>0)
            {                
                Console.WriteLine($"<<{i}>> VS <<{a}>> - OK");
            }
            else
            {
                Console.WriteLine($"<<{i}>> VS <<{a}>> - KO");
            }                             
            
            Console.ReadKey();

        }
        
    }
}
