using System;

namespace ilkders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Doğukan");//WriteLine yazar ve bir satır boşluk bırakır.
            Console.Write("Ateş");//yazar ama aynı satırdan devam eder.
            Console.Write(" Nasılsınız?");
            Console.WriteLine("\nLorem Ipsum,\ndizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.\nLorem Ipsum, adı bilinmeyen bir matbaacıdır.");*/

            int sayırbir;
            short sayı2;
            sbyte sayı3;
            double sayı4;
            char tuş;
            string ad;

            sayırbir = 10000005;
            Console.WriteLine(sayırbir);

            sayı2 = 4572;
            Console.WriteLine(sayırbir);

            sayı3 = 100;
            Console.WriteLine(sayırbir);

            tuş = 'D';//char atamallarında tek tırnak kullanılır.

            ad = "dogukan";

            Console.WriteLine("1.sayı = {0}  2.sayı = {1} ", sayırbir, sayı2);

           
        }
    }
}