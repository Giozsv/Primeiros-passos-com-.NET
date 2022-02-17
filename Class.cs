using System.Linq;
using System.Collections.Generic;
using Conjuntos.Helper;


namespace Conjuntos
{
    class Progran
    {
        static void Main(string[] args)
        { 
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
