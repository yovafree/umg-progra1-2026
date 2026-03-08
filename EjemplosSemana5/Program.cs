using System.Diagnostics.CodeAnalysis;

namespace EjemplosSemana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[,] estudiantes = new string[4,10];

            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine("Ingrese el nombre del estudiante");
            //    estudiantes[0, i] = Console.ReadLine();

            //    Console.WriteLine("Ingrese la nota 1");
            //    estudiantes[1, i] = Console.ReadLine();

            //    Console.WriteLine("Ingrese la nota 2");
            //    estudiantes[2, i] = Console.ReadLine();

            //    Console.WriteLine("Ingrese la nota 3");
            //    estudiantes[3, i] = Console.ReadLine();
            //}

            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine($"La nota del estudiante {estudiantes[0, i]} es: ");
            //    int sumNota = 0;
            //    for (int j = 1; j < 4; j++) {
            //        sumNota += int.Parse(estudiantes[j, i]); 
            //    }

            //    int promedio = sumNota / 3;

            //    Console.WriteLine($"{promedio}");
            //}

            int resultado = Suma(2, 3);
            Console.WriteLine(resultado);

            resultado = Suma(3, 2, 4);
            Console.WriteLine(resultado);


            int resu = Factorial(10);

            Console.WriteLine("El factorial es: " + resu);

            int resu2 = SumarN(10);
            Console.WriteLine("La suma es: " + resu2);
        }

        static int Suma(int n1, int n2) { 
            return n1 + n2;
        }

        // Sobrecarga de métodos
        static int Suma(int n1, int n2, int n3) { 
            return n1 + n2 + n3;
        }

        //static int Factorial(int n)
        //{
        //    int factorial = n;
        //    for (int i = 1; i < n; i++)
        //    {
        //        factorial = factorial * (n - i);
        //    }

        //    return factorial;
        //}

        static int Factorial(int n) {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        static int SumarN(int n) {
            if (n == 1) return 1;
            return n + SumarN(n - 1);
        }
    }
}
