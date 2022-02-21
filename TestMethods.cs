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
            Dictionary<int, EValueType> resultado = new Dictionary<int, EValueType>(); //Diccionario a entregar al problema

            int[] arregloLlaves = new int[sourceDict.Count];
            sourceDict.Keys.CopyTo(arregloLlaves, 0);
            EValueType[] arregloValores = new EValueType[sourceDict.Count];
            sourceDict.Values.CopyTo(arregloValores, 0);

            for (int i = 0; i < arregloLlaves.Length; i++)
            {
                for (int k = 0; k < arregloLlaves.Length - 1; k++)
                {
                    int siguienteLlave = arregloLlaves[k + 1];
                    EValueType siguienteValor = arregloValores[k + 1];

                    if (arregloLlaves[k] < siguienteLlave)
                    {
                        arregloLlaves[k + 1] = arregloLlaves[k];
                        arregloLlaves[k] = siguienteLlave;

                        arregloValores[k + 1] = arregloValores[k];
                        arregloValores[k] = siguienteValor;
                    }
                }
            }

            for (int i = 0; i < sourceDict.Count; i++)
            {
                resultado.Add(arregloLlaves[i], arregloValores[i]);
            }

            return resultado;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket> colaPagos = new Queue<Ticket>();
            Queue<Ticket> colaSuscripcion = new Queue<Ticket>();
            Queue<Ticket> colaCancelacion = new Queue<Ticket>();

            Queue<Ticket>[] resultado = { colaPagos, colaSuscripcion, colaCancelacion };

            Ticket[] copia = sourceList.ToArray();

            for (int i = 0; i < copia.Length; i++)
            {
                for (int k = 0; k < copia.Length - 1; k++)
                {
                    int siguienteTurno = copia[k + 1].Turn;
                    Ticket siguienteTicket = copia[k + 1];

                    if (copia[k].Turn > siguienteTurno)
                    {
                        copia[k + 1] = copia[k];
                        copia[k] = siguienteTicket;
                    }
                }
            }

            for (int i = 0; i < copia.Length; i++)
            {
                if (copia[i].RequestType == Ticket.ERequestType.Payment) colaPagos.Enqueue(copia[i]);
                else if (copia[i].RequestType == Ticket.ERequestType.Subscription) colaSuscripcion.Enqueue(copia[i]);
                else colaCancelacion.Enqueue(copia[i]);
            }

            return resultado;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}