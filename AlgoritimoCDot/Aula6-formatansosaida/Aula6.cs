using System;

namespace Aula6_formatansosaida
{
    class Aula6
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 10;   y = 2;  z = 20;

            Console.WriteLine("x={0}, y={1}, z={2}", x,y,z);

            Console.WriteLine("x={0}\ny={1}\nz={2}", x, y, z);
            //  \n= enter ele pula uma linha

            Console.WriteLine("x={0}\ty={1}\tz={2}", x, y, z);
            // \t= tubulação ou espaço




        }
    }
}
