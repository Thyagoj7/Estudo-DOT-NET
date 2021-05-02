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

            int setadireitatotal=0;
            int setaesquerdatotal=0;
            int pontodiamantado=0;

            int d = setadireitatotal;
            int e = setaesquerdatotal;
            int p = pontodiamantado;
            
           

            for (int i = 0; i < x; i++)
            {
                resultado = alfanumericoAleatorio(tamanho);

                for (int a = 0; a < y; a++)
                {
                    string txt = resultado[a].ToString();

                    

                    Lapidar(txt, d, e, p);



                }

                Lapidatotal(d, e, p);


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
        public static int Lapidar(string txt, int direitat, int esquerdat, int pontot)
        {
            if (txt == ">")
            {
                direitat = direitat + 1;
                return direitat;

            }
            else if (txt == "<")
            {
                esquerdat = esquerdat + 1;

                return esquerdat;
            }
            else if (txt == ".")

            {
                pontot = pontot + 1;
                return pontot;

            }

            return 0;
        }

        public static int Lapidatotal(int dt,int et, int pt)
        {
           
            
            int resto = (dt % et);
            int soma = (dt + et);
            int sub = (soma - resto);
            int total = sub / 2;

            return total;
            



        }





        
           
           

          











        }
       



       

                    

        }


                



            
  
