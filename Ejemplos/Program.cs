namespace Ejemplos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 9;
            int num2 = 5;
            int num3 = 0;
            int num4 = 0;
            

            Console.WriteLine("Ingrese el valor de Num1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de Num2:");
            num2 = int.Parse(Console.ReadLine());

            // Estructura de control IF Simple
            if (num1 > num2) {
                Console.WriteLine($"Num 1 es mayor el valor es {num1}");
            }
            else {
                if (num1 == num2)
                {
                    Console.WriteLine("Ambos son iguales");
                }
                else {
                    Console.WriteLine($"Num 2 es mayor, el valor es {num2}");
                }
                    
            }
            // num1 = 5
            // num2 = 5
            // Estructura de control IF Multiple
            if (num1 > num2)
            {
                Console.WriteLine($"Num 1 es mayor el valor es {num1}");
            }
            else if (num1 == num2) {
                Console.WriteLine($"Num1 y Num2 son iguales, el valor {num1}");
            }
            else
            {
                Console.WriteLine($"Num 2 es mayor, el valor es {num2}");
            }

            // Estructuras de Control Ciclicas
            // For, Do While,  While

            for (int i = 1; i <= 10; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("");
            }

            int n = 0;
            // Do
            do {
                Console.WriteLine(n);
                n++;
            } while (n<=100);

            // While
            n = 0;
            while (n<=100) { 
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
