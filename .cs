using System.Linq;
using System.Collections.Generic;
using Conjuntos.Helper;


namespace Conjuntos
{
    class Progran
    {
        static void Main(string[] args)
        {  
          // Stack = Pilha - LIFO(Último a entrar, primeiro a sair) leitura é realizado a partir do último elemento
             Stack<string> pilhaLivros = new Stack<string>();

             pilhaLivros.Push(".NET");
             pilhaLivros.Push("C#");
             pilhaLivros.Push("Java");

            System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
             while (pilhaLivros.Count > 0)        //while = enquanto tiver elemento = executa
             {
                 System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}"); //Peek = obter uma prévia do elemento do topo ds pilha
                 System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");              //Pop = obter o último item da pilha (topo da pilha) = e remove
             }

             System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");



        //Queue = Fila - FIFO(Primeiro que entrar, primeiro que sai           
             Queue<string> fila = new Queue<string>();
             fila.Enqueue("Giovanna");
             fila.Enqueue("Jonatas");
             fila.Enqueue("Giuliana");
        
             System.Console.WriteLine($"Pesssoas na fila: {fila.Count}");

             while (fila.Count > 0)       //while = ler a fila e ir removendo conforme o chamado
             {
                 System.Console.WriteLine($"Vez de: {fila.Peek()}");            //Peek = retorna a pessoa no começo sem remover
                 System.Console.WriteLine($"{fila.Dequeue()} atendido");       //Dequeue = primeiro elemento é retornado e removido
             }

            System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            



        //COLEÇÕES GENÉRICAS
             OperaçoesLista opLista = new OperaçoesLista();
             List<string> estados = new List<string> { "SP", "MG", "BA" };
             string[] estadosArray = new string[2] { "SC", "MT"};

               estados.Add("SP");
               estados.Add("MG");
               estados.Add("BA");

             System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");     //prop Count = retorna o nº de element na lista

             opLista.ImprimirListaString(estados);

             System.Console.WriteLine("Removendo o elemento");                   //remove um elemento e reposiciona lista
             estados.Remove("MG");

             estados.AddRange(estadosArray);
             estados.Insert(1, "RJ");

             opLista.ImprimirListaString(estados);

            foreach (var item in estados)
             {
                System.Console.WriteLine(item);
             }
