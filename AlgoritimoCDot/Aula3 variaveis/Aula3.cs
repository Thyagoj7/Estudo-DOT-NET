using System;

namespace Aula3_variaveis
{
    class Aula3

    {
        int numeral = 100;
        static void Main(string[] args)
        {
            byte n1=10;
            int numero=100;
            char letra = '8';
            float y = 10.4f;
            string nome = "Thyago";

            var mutavel = nome;

            Console.WriteLine(n1);
            Console.WriteLine(numero);
            Console.WriteLine(letra);
            Console.WriteLine(y);
            Console.WriteLine(".........." + mutavel + "..................");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            int x, z, a;
            x = 10;
            z = 20;
            a = 100;

            Console.WriteLine(x + z);
        }

        void aula4()
        {
            //Console.WriteLine(x); Esta varivael não pode ser usada pois ela esta em outro metodo.
            Console.WriteLine(numeral);
        } 
    }
}
