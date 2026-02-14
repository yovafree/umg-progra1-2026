// Función de tipo IO
Console.WriteLine("Hola Mundo, Programación I");

// Definición de Variable
int numero = 10;

numero = numero + 5;
Console.WriteLine("El valor de numero es: " + numero);

string nombre = "Juan";
string apellido = "Pérez";
string nombreCompleto = nombre + " " + apellido;
Console.WriteLine("El nombre completo es: " + nombreCompleto);

int num1 = 20;
int num2 = 30;
int suma = num1 + num2;
Console.WriteLine("La suma de num1 y num2 es: " + suma);


Console.WriteLine("Ingrese un número:");
string input = Console.ReadLine();

num1 = int.Parse(input);

Console.WriteLine("Ingrese otro número:");
input = Console.ReadLine();
num2 = int.Parse(input);

suma = num1 + num2;
Console.WriteLine("La suma de los números ingresados es: " + suma);

// Uso de interpolación de cadenas
Console.WriteLine($"El valor de num1 es: {num1} y el valor de num2 es: {num2}");

string mensaje = $"La suma de {num1} y {num2} es: {suma}";
Console.WriteLine(mensaje);

// Es posible utilizar pausas
Console.ReadKey();

/*
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
*/

