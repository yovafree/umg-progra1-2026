using System.IO;

string winDir = Directory.GetCurrentDirectory();

List<string> estudiantes = new List<string>();

StreamReader reader = new StreamReader(winDir + "\\estudiantes.txt");
try
{
    do
    {
        estudiantes.Add(reader.ReadLine());
    }
    while (reader.Peek() != -1);
}
catch
{
    Console.WriteLine("Está vacío el archivo");
}
finally
{
    reader.Close();
}

foreach (string line in estudiantes) { 
    Console.WriteLine(line);
}

StreamWriter writer = new StreamWriter(winDir + "\\estudiantes.txt");

foreach (string line in estudiantes)
{
    writer.WriteLine(line);
}

writer.WriteLine("Diego Cacao");
writer.Close();

// Ver las subcarpetas del proyecto actual
string[] dirs = Directory.GetDirectories(winDir);
foreach (string dir in dirs)
{
    Console.WriteLine($"{dir}");
}

// Lectura del archivo estudiantes.txt

StreamReader reader2 = new StreamReader(winDir + "\\estudiantes2.txt");
try
{
    do
    {
        string[] line = reader2.ReadLine().Split(";");
        string codigo = line[0];
        string nombre = line[1];
        string edad = line[2];
        string carrera = line[3];

        Console.WriteLine($"Código: {codigo} - Nombre: {nombre} - Edad: {edad} - Carrera: {carrera}");
    }
    while (reader2.Peek() != -1);
}
catch
{
    Console.WriteLine("Está vacío el archivo");
}
finally
{
    reader.Close();
}