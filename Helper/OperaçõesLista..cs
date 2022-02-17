namespace Conjuntos.Helper
{
    public class OperaçoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
             for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"índice {i}, Valor: {lista[i]}");
            }
        }
    }
}
