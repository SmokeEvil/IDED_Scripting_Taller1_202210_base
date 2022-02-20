using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> resultado = new Stack<int>();

            int[] copia = sourceStack.ToArray();

            Stack<int> primerosResultados = new Stack<int>();

            for (int i = 0; i < copia.Length; i++)
            {
                int actual = copia[i];
                int mayor = actual;

                for (int j = i; j >= 0; j--)
                {
                    if (copia[j] > mayor) mayor = copia[j];

                }

                if (mayor == actual) primerosResultados.Push(-1);
                else primerosResultados.Push(mayor);

            }

            while (primerosResultados.Count > 0)
            {
                resultado.Push(primerosResultados.Pop());
            }

            return resultado;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> resultado = new Dictionary<int, EValueType>();

            int[] copia = new int[sourceArr.Length];
            sourceArr.CopyTo(copia, 0);

            for (int i = 0; i < copia.Length; i++)
            {
                if (copia[i] % 2 == 0) resultado.Add(copia[i], EValueType.Two);
                else if (copia[i] % 3 == 0) resultado.Add(copia[i], EValueType.Three);
                else if (copia[i] % 5 == 0) resultado.Add(copia[i], EValueType.Five);
                else if (copia[i] % 7 == 0) resultado.Add(copia[i], EValueType.Seven);
                else resultado.Add(copia[i], EValueType.Prime);
            }

            return resultado;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int resultado;
            int contador = 0;

            foreach (KeyValuePair<int, EValueType> dupla in sourceDict)
            {
                if (dupla.Value == type) contador++;
            }

            resultado = contador;
            return resultado;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}