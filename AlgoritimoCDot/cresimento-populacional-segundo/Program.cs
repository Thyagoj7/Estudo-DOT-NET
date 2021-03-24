using System;
using System.Globalization;

namespace cresimento_populacional_segundo
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine()); //Variavel que define os casos de teste!
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;
            for (int i = 0; i < t; i++)
            {
                anos = 0;


                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                //declare as variaveis corretamente
                cpa = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture);
                cpb = Convert.ToDouble(valores[3], CultureInfo.InvariantCulture);

                cpa = cpa / 100;
                cpb = cpb / 100;

                while (pa <= pb)
                {


                    pa = (int)(pa * (1 + cpa));
                    pb = (int)(pb * (1 + cpb));
                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;

                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine("{0} anos.", anos);
                }

            }

        }

    }
