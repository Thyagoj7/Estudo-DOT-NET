using System;

namespace DIO_Solução_de_problemas_em_C
{
    class DioSolução1
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = Convert.ToDouble(distancia / combustivelGasto);
             //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("{0:0.000} km/l", consumoMedio);

        }
    }
    
}
