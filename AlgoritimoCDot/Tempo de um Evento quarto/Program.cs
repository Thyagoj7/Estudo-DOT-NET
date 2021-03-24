using System;

namespace Tempo_de_um_Evento_quarto
{
    class Program
    {
        static void Main(string[] args)
        {

            int diaInicio, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
            int dias, horas, minutos, segundos;
            int inicio, fim, data;


            string[] dadosInicio = Console.ReadLine().Split(' ');
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(" : ");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);


            string[] dadosTermino = Console.ReadLine().Split(' ');
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(" : ");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);

            inicio = segundoMomentoInicio + minutoMomentoInicio * 60 + horaMomentoInicio * 60 * 60 + diaInicio * 24 * 60 * 60;
            fim = segundoMomentoTermino + minutoMomentoTermino * 60 + horaMomentoTermino * 60 * 60 + diaTermino * 24 * 60 * 60;

            data = fim - inicio;

            dias = data / (24 * 60 * 60);
            horas = (data - dias * 24 * 60 * 60) / (60 * 60);
            minutos = (data - dias * 24 * 60 * 60 - horas * 60 * 60) / 60;
            segundos = (data - dias * 24 * 60 * 60 - horas * 60 * 60 - minutos * 60);

            Console.WriteLine("{0} dia(s)", dias);
            Console.WriteLine("{0} hora(s)", horas);
            Console.WriteLine("{0} minuto(s)", minutos);
            Console.WriteLine("{0} segundo(s)", segundos);

        }
    }
}
