using System;

namespace MetodosCFB
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, res;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            res = soma(x, y);


            //Console.WriteLine("O resultado e " + soma(x,y)); poderia chamar a soma aqui tambem assim.

            Console.WriteLine("O resultado e " + res);

            /*for(int i=0; i<10; i++)
          {
              CFB();
          }*/

            //CFB(); //Posso chamar o metodo com c chamada assim.
        }
        static int soma(int a, int b)
        {
            int res = a + b;
            return res;
        }

        static void CFB()
        {
            Console.WriteLine("Ola");
        }

        /*static void soma(int n1, int n2)//Desta forma não retorna valor vai retornar o resultado do método.
        {
            int res=n1+n2;
            Console.WriteLine("A soma de {0} + {1} é igual a {2}", n1, n2, res);
        }*/














    }
}
