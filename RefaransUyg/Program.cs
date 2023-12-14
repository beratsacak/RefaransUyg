using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefaransUyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = sayi1;
            sayi2 = 50;
            Console.WriteLine("sayi1 = " + sayi1);
            Console.WriteLine("sayi2 =" + sayi2);
            Console.WriteLine("=====================");
            SayiTutuci st1 = new SayiTutuci();
            st1.A = 10;
            SayiTutuci st2 = st1;
            st2.A = 50;
            Console.WriteLine("sayi 1 = " + st1.A);
            Console.WriteLine("st2.A değeri: " + st2.A); 

        }
    }
    class SayiTutuci
    {
        public int A { get; set; }
    }
}
