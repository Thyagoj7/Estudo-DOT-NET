using System;
using System.Linq;

namespace DiamantesDaAreia_Uri_1069
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;
            int tamanho = 10;

            int x = Convert.ToInt32(Console.ReadLine());
            int y = 10;

            int direita = 0;
            int esquerda = 0;
            int ponto=0;
            int c;
            int d;
            int resultadot = 0;

            for ( int i=0; i < x; i++)
            {
                resultado = alfanumericoAleatorio(tamanho);

                

                for( int a=0; a < y; a++) {
                    string txt = resultado[a].ToString();

                   if (txt == "<")
                    {
                        esquerda = 0;

                        esquerda++;



                    } else if (txt == ">")
                    {
                        direita = 0;
                        direita++;
                    }
                    else if (txt == ".")

                    {
                        ponto = 0;
                        ponto++;
                    }

                    int f = esquerda;
                    int e = direita;
                    int g = ponto;

                    if (a == y)
                    {
                        int diviso= ( f % e);
                        int som1 = diviso + ponto;
                        int meno = y - som1;
                        resultadot = meno / 2;
                        Console.WriteLine(resultadot);
                    }

                    

                }


                



            }
        }

        public static string alfanumericoAleatorio(int tamanho)
        {
            var chars = ".<>";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
