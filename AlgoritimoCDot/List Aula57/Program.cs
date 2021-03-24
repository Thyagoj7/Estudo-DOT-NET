using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        // A stack can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nPopping '{0}'", numbers.Pop()); //Pop Remove um elemento da parte superior do Stack<T> .
        Console.WriteLine("Peek at next item to destack: {0}",
            numbers.Peek()); //Peek Retorna um elemento que está na parte superior do Stack<T> , mas não o Remove do Stack<T> .
        Console.WriteLine("Popping '{0}'", numbers.Pop());

        //Crie uma cópia da pilha, usando o método ToArray e o
        // construtor que aceita um IEnumerable <T>.
        Stack<string> stack2 = new Stack<string>(numbers.ToArray());

        Console.WriteLine("\nContents of the first copy:");
        foreach (string number in stack2)
        {
            Console.WriteLine(number);
        }

        // Crie uma matriz com o dobro do tamanho da pilha e copie o
        // elementos da pilha, começando no meio do
        // array.
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        //Crie uma segunda pilha, usando o construtor que aceita um
        //IEnumerable (Of T).
        Stack<string> stack3 = new Stack<string>(array2);

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
        foreach (string number in stack3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));

        Console.WriteLine("\nstack2.Clear()");
        stack2.Clear();
        Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
    }
}

//Documentação// https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.stack-1?view=net-5.0 //
//Push Insere um elemento na parte superior do Stack 
//A capacidade de um Stack<T> é o número de elementos que o Stack<T> pode conter. À medida que os elementos são adicionados a um Stack<T> , a capacidade é aumentada automaticamente conforme necessário, realocando a matriz interna. A capacidade pode ser reduzida chamando TrimExcess 

//CONSTRUTORES
//Stack<T>()  Inicializa uma nova instância da classe Stack<T> que está vazia e tem a capacidade inicial padrão.
//Stack<T>(IEnumerable<T>) Inicializa uma nova instância da classe Stack<T>, que contém os elementos copiados da coleção especificada e tem capacidade suficiente para acomodar o número de elementos copiado
//Stack<T>(Int32) Inicializa uma nova instância da classe Stack<T> que está vazia e tem a capacidade inicial especificada ou a capacidade inicial padrão, a que for maior.


//PROPRIEDADES 
//Count  Obtém o número de elementos contidos no Stack<T>.

//MÉTODOS
//Clear()  Remove todos os objetos da Stack<T>.
//Contains(T)  Determina se um elemento está no Stack<T>.
//CopyTo(T[], Int32)	Copia o Stack<T> para uma Array de uma dimensão existente, começando no índice de matriz especificado.



/* This code example produces the following output:

five
four
three
two
one

Popping 'five'
Peek at next item to destack: four
Popping 'four'

Contents of the first copy:
one
two
three

Contents of the second copy, with duplicates and nulls:
one
two
three




stack2.Contains("four") = False

stack2.Clear()

stack2.Count = 0
 */