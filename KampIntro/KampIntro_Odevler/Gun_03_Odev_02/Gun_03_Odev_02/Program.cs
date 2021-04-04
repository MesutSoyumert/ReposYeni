using System;

namespace Gun_03_Odev_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int RefDegisken = 3;
            int degisken2 = 5;

            Console.WriteLine("ref ile çağrılan metod sonucu");
            Console.WriteLine(RefMethod(ref RefDegisken, degisken2));
            Console.ReadLine();

            int OutDegisken;
            int degisken3 = 9;

            Console.WriteLine("out ile çağrılan metod sonucu");
            Console.WriteLine(OutMethod(out OutDegisken, degisken3));
            Console.ReadLine();
        }

        static int RefMethod(ref int RefDegisken1, int degisken2)
        {
            return RefDegisken1 + degisken2;
        }
        static int OutMethod(out int OutDegisken, int degisken3)
        {
            OutDegisken = 29;
            return OutDegisken + degisken3;
        }
    }
}
