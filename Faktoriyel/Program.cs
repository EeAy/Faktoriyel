using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int a= 1;
            
            if (sayi <= 1 && sayi != 0)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
            }
            else
            {
                for (int i = 1; i < sayi; i++)
                {
                    a += a * i;
                }
                Console.WriteLine( sayi + " sayısının faktoriyel hesabı :" + a);
            }

            Console.ReadLine();
        }

    }
}
