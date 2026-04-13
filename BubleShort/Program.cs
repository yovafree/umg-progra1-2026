namespace BubleShort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            int[] ordenado = bubbleShort(arr);

            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.Write(ordenado[i] + " ");
            }

        }

        static int[] bubbleShort(int[] arr) { 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
