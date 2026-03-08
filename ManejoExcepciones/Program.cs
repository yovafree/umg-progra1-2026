namespace ManejoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int x = 100; x >= 1; x--)
                {
                    int y = 25 / x;
                    Console.WriteLine(y);
                }

                int[] array1 = { 1, 2, 3 };

                int resu = array1[5];
            }
            catch (DivideByZeroException ex) { 
                Console.WriteLine("No se permite dividir dentro de 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ingresó a la excepción genérica");
                Console.WriteLine(ex.ToString());
            }


            for (int x = 1; x <= 10; x++) {
                Console.WriteLine($"{x} * 10 = {x * 10}");
            }
        }
    }
}
