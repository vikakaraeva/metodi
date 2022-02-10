using System;

namespace методы
{
    class методы
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            double Squarecircle(double R)
            {
                return Math.PI * Math.Pow(R, 2);
            }
            double Sb = Squarecircle(10);
            double S1 = Squarecircle(1);
            double S2 = Squarecircle(2.5);
            double S3 = Squarecircle(2.6);

            double Sf = Math.Round(Sb - S1 - S2 - S3,2);
            Console.WriteLine($"Площадь фигруы ={Sf}");
            Console.ReadKey();
        }
    }
}
