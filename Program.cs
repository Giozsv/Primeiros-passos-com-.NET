
using System.Linq;
using System.Collections.Generic;
using Conjuntos.Helper;


namespace Conjuntos
{
    class Progran
    {
        static void Main(string[] args)
        {               
             int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

           var mínimo = arrayNumeros.Min();
           var maximo = arrayNumeros.Max();
           var medio = arrayNumeros.Average();
           var soma = arrayNumeros.Sum();
           var arrayUnico = arrayNumeros.Distinct().ToArray();     //distinct = retorna elementos distintos de uma sequencia
 
           System.Console.WriteLine($"Mínimo: {mínimo}");
           System.Console.WriteLine($"Maximo: {maximo}");
           System.Console.WriteLine($"Medio: {medio}");
           System.Console.WriteLine($"Soma: {soma}");
           System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}"); 
           System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayNumeros)}");
            
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
            
            OperaçoesArray op = new OperaçoesArray();

             int[] array = new int[5] { 6, 3, 8, 1, 9 };                 //metade irá receber valores do arrayCopia
             int[] arrayCopia = new int[10];                             // sem valor declarado = padrão do valor int 0
             string[] arrayString = op.ConverterParaArrayString(array);
            
             int valorProcurado = 8;

             System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

             op.RedidmensionarArray(ref array, array.Length * 2);
            
             System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");
            
        ///REDIMENSIONAR ARRAY NOVOTAMANHO
             System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

             op.RedidmensionarArray(ref array, array.Length * 2);
            
            System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");


            
        ///ENCONTRAR INDICE DO VALOR
             int indice = op.ObterIndice(array, valorProcurado);

             if (indice > -1)  //posição invalida
             {
                 System.Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado, indice);            //0 substituido pelo var valorProcurado\\ 1 substituido pela var Indice 
             }                           //"$"O índice do elemento {valorProcurado} é: {indice}"); --> interpolação de string = concatenar string + var              
             else
             {
                 System.Console.WriteLine("Valor não existe no array");
             }


             int valorAchado = op.ObterValor(array, valorProcurado);

             if (valorAchado > 0)
             {
                 System.Console.WriteLine("Encontrei o valor");
             }
             else
             {
                 System.Console.WriteLine("Não encontrei o valor");
             }
        ///VERIFICANDO TODOS OS ARRAY
            bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

             if (TodosMaiorQue)
             {
                 System.Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
             }
             else 
            {
                 System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            }

        ///VARIFICANDO 1 ARRAY
             bool existe = op.Existe(array, valorProcurado );

             if (existe)
             {
                 System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
             }
             else
             {
                 System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
             }

            
             System.Console.WriteLine("Array original:");
             op.ImprimirArray(array);

             op.OrdenarBubbleSort(ref array);
             op.Ordenar(ref array);

             System.Console.WriteLine("Array ordenado:");
             op.ImprimirArray(array);

             System.Console.WriteLine("Array antes da cópia:");
             op.ImprimirArray(arrayCopia);

             op.Copiar(ref array, ref arrayCopia);
             System.Console.WriteLine("Array após a cópia:");
             op.ImprimirArray(arrayCopia);


             int[,] matriz = new int[4, 2]
             {  //L  /C
                 { 8, 8 },
                 { 10, 20},
                 { 20, 100},
                 {90, 200}
             }

             for (int i = 0; i < matriz.GetLength(0); i++)       //get.Lenght =
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {
                     System.Console.WriteLine(matriz[i, j]);
                }
             }


            int[] arrayInteiros = new int [3];    //array vazio

            arrayInteiros[0] = 10;                //array na posição 0 recebe valor de 10
            arrayInteiros[1] = 20;
            arrayInteiros[2] = int.Parse("30");                //limite de posição   ------>  //int.parse = nº 30 em string p/ converter em inteiro

             arrayInteiros[3] = 30;                    //erro retorno = index do array fora do alcance(limite)
             
              System.Console.WriteLine("Percorrendo o array pelo for"); //--utiliza um contador
              for (int i = 0; i < arrayInteiros.Length; i++)      // imprimir todos os elementos\\ lenght retorna inteiro = capacidade máx
             //indicador controlar\\
             {
                  System.Console.WriteLine(arrayInteiros[i]);      //cada vez que percecorrer = incrementa +1
              }

              System.Console.WriteLine("Percorrendo o array pelo forEach"); //--não utiliza um contador - utiliza a var Item
              foreach ( int item in arrayInteiros)
             //sem indicador de posição\\
             {
                 System.Console.WriteLine(item);
        }
    }
}

            
        }
    }
}
