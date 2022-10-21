using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi={23,12,4,86,72,3,11,17};

            Console.WriteLine("***Sırasız sayı dizisi***");
            foreach (var sayı in sayiDizisi)
                Console.WriteLine(sayı);

            Console.WriteLine("***Sıralı sayı dizisi***");
            Array.Sort(sayiDizisi);
            foreach (var sayı in sayiDizisi)
                Console.WriteLine(sayı);
                
            Console.WriteLine("***Array clear***");
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayı in sayiDizisi)
                Console.WriteLine(sayı);

            Console.WriteLine("***Sıralı sayı dizisi***");
            Array.Reverse(sayiDizisi);
            foreach (var sayı in sayiDizisi)
                Console.WriteLine(sayı);
            
            Console.WriteLine("***Indexof***");
            
                   Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            Console.WriteLine("***Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var sayı in sayiDizisi)
                Console.WriteLine(sayı);

        }
    }
}