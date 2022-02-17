
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
        }
    }
}
