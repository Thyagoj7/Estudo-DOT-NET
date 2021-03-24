using System;

namespace Piralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string v = Convert.ToString(n);
            string comunicacaoInvertida = "";

            for (int i = n.ToString().Length; i > 0; i--)
            {
                string decodificacao = v.Substring(i - 1, 1);
                comunicacaoInvertida += decodificacao;
            }

            Console.WriteLine(comunicacaoInvertida);
        }
    }
}