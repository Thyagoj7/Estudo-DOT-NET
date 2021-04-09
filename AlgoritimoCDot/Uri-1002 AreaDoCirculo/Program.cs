using System;

namespace Uri_1002_AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double n = 3.14159;
            double raio=0;
            double area;
            double y = 2;

            raio = Convert.ToDouble(Console.ReadLine());

            raio = Math.Pow(raio, y);

            area= raio * n;

            area= Math.Round(area, 4);

         
            

            Console.WriteLine("A =" + area);










        }
       
    }
}
