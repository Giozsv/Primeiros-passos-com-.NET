namespace Conjuntos.Helper
{
    public class OperaçoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)     //referencia = trabalhar com a mesma var de array
        {
            int temp = 0;                 // var temp = armazenar/troca sem perder a inf do valor anterior

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)        //lógica da troca    // n - 1
                {
                    //posição de troca
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];         //receber um valor de array = prox posição na var temp
                        array[j + 1] = array[j];    //trocar o prox com o atual = posição atual do array
                         array[j] = temp;           //depois da troca = volta o valor da var temp
                    }
                }
            }
        }
        public void ImprimirArray(int [] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);   
        }

        public void Ordenar(ref int[] array) 
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestiono)
        {
            Array.Copy(array, arrayDestiono, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento >= valor);          //array.Exist retorna um boleano = se existir TRUE = se não existir FALSE
        }                                                                        // == ; <= ; >= ; != \\

        public bool TodosMaiorQue(int[] array, int valor) 
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);               
        }                                                                        
        
        public int ObterIndice(int[] array, int valor)
        { 
            return Array.IndexOf(array, valor);                                              //findIndex = usar expressão q não precisa ser de igualdade
        }                                                                                    //IndexOf = não recebe espressão, receb diretamente valor e precisa de igualdade                                        

        public void RedidmensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);                                  //Resize = mudar capacidade o array (nº)
        }

        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());       //elemento representa do array int >>> conversão >>> string
        }
    }
}
