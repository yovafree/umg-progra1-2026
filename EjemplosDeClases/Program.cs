using System.Diagnostics.CodeAnalysis;

namespace EjemplosDeClases
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 5;
            //int num2 = 2;

            //int resu = suma(num1, num2);
            //Console.WriteLine(resu);

            //resu = resta(num1, num2);
            //Console.WriteLine(resu);

            //resu = division(num1, num2);
            //Console.WriteLine(resu);

            //resu = multiplicacion(num1, num2);
            //Console.WriteLine(resu);

            //resu = suma(10, 8);
            //Console.WriteLine(resu);

            //resu = suma(10, 20);
            //Console.WriteLine(resu);

            //resu = mayor(10, 2);
            //Console.WriteLine("El mayor es " + resu);

            //resu = menor(10, 2);
            //Console.WriteLine("El menor es " + resu);

            //tablaMultiplicar(7);

            //tablaMultiplicar(3);

            //tablaMultiplicar(4);

            //tablaMultiplicar(8);
            string mensaje = "Este es un mensaje mas largo permite visualizar nuestro cifrado en mensajes largos";
            string cifrado = cifrarCesar(mensaje);
            string descifrado = descifrarCesar(cifrado);
            Console.WriteLine("ORIGINAL: " + mensaje);
            Console.WriteLine("CIFRADO: " + cifrado);
            Console.WriteLine("DESCIFRADO: " + descifrado);
        }

        static int suma(int n1, int n2) {
            int r = n1 + n2;
            return r;
        }

        static int resta(int n1, int n2)
        {
            int r = n1 - n2;
            return r;
        }

        static int multiplicacion(int n1, int n2)
        {
            int r = n1 * n2;
            return r;
        }

        static int division(int n1, int n2)
        {
            int r = n1 / n2;
            return r;
        }

        static int mayor(int n1, int n2) {
            if (n1 < n2)
            {
                return n2;
            }
            else {
                return n1;
            }
        }

        static int menor(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n2;
            }
            else
            {
                return n1;
            }
        }

        static void tablaMultiplicar(int n)
        {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{i} * {n} = {i * n}");
            }
        }

        static string cifrarCesar(string frase) {
            string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ _";
            string mensajeCifrado = "";

            for (int i = 0; i < frase.Length; i++) { 
                char c = frase[i];
                
                for (int j = 0; j < alfabeto.Length; j++) {
                    if (alfabeto[j] == c) {
                        mensajeCifrado = mensajeCifrado+ ""+alfabeto[j+1];
                    }
                }
            }

            return mensajeCifrado;
        }

        static string descifrarCesar(string frase)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ _";
            string mensajeDescifrado = "";

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase[i];

                for (int j = 0; j < alfabeto.Length; j++)
                {
                    if (alfabeto[j] == c)
                    {
                        mensajeDescifrado = mensajeDescifrado + "" + alfabeto[j - 1];
                    }
                }
            }

            return mensajeDescifrado;
        }
    }
}
