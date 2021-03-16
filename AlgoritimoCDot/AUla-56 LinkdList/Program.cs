using System;
using System.Collections.Generic;

namespace AUla_56_LinkdList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string>  transport = new LinkedList<string> ();

            transport.AddFirst(" Carro");       //AddFirst adciona no inicio da lista//
            transport.AddFirst(" Moto");
            transport.AddFirst(" Caminhao");
            transport.AddFirst(" Barco");

            transport.AddLast(" Bicicleta");     //AddLast Adciona ao final da lista//  

            LinkedListNode<string>no;
            no=transport.FindLast(" Carro");  //Vai segurar o elemento carro no nó//
            transport.AddAfter(no, " Skate");   //Vai acrescentar o elemento skate após o elemento do nó//
            transport.AddBefore(no, " Patins");

            //transport.Clear();  //Limpa todos os elementos//

            if(transport.Find(" Carro") == null)      //vai procurar o elemento na lista//
            {
                Console.WriteLine("Não encontrado");
            }
            else
            {
                Console.WriteLine("Elemento encontrado");
            }

            transport.Remove(" Carro");  //Remeve um elemento da lista//

            transport.RemoveFirst(); //Remove o primeiro elemento//
            transport.RemoveLast();  //Remove o ultimo elmento//





            foreach( string t in transport)
            {
                Console.WriteLine("Transport{0}", t);
            }

        }
    }
}
