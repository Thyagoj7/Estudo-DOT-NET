using System;

namespace Teste
{
    public class TestteFor{
    
        public static void Main(string[] args)
        {
           for(int i=0; i<3; i++)
            {
                for (int j=1; j<3; j++)
                {
                    if(i%j == 0)
                    {
                        continue;

                    }
                    else
                    {
                        Console.WriteLine("i=" + i + "j=" + j);
                    }
                }
            }
            
            
            
            /*int i, soma = 0;
            for(i=0; i<=5; i++)
            {
                if (i == 4)
                    continue;
                soma += i;
            }*/


            //Console.WriteLine(soma);
        }
    }
}
