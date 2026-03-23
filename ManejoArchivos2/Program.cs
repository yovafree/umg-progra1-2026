namespace ManejoArchivos2
{
    public class Program
    {
        static string dirEstudiantes = Directory.GetCurrentDirectory() + "\\estudiantes2.txt";
        static List<Estudiante> estudiantes = new List<Estudiante>();

        static void Main(string[] args)
        {
            LeerEstudiantes();
            do { 
                Console.WriteLine("Menú:"); 
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Mostrar Estudiantes");
                Console.WriteLine("3. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) { 
                    case 1:
                        Estudiante nEstudiante = new Estudiante();
                        Console.WriteLine("Ingrese el código del estudiante:");
                        nEstudiante.CodEstudiante = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del estudiante:");
                        nEstudiante.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad del estudiante:");
                        nEstudiante.Edad = Console.ReadLine();
                        Console.WriteLine("Ingrese la carrera del estudiante:");
                        nEstudiante.Carrera = Console.ReadLine();

                        GuardarEstudiantes(nEstudiante);
                        break;
                    case 2:
                        MostrarEstudiantes();
                        break;
                    case 3:
                        
                        break;
                }


            } while (true);
        }

        static void GuardarEstudiantes(Estudiante nEstudiante) {
            StreamWriter writer = new StreamWriter(dirEstudiantes);
            foreach (Estudiante estudiante in estudiantes)
            {
                writer.WriteLine($"{estudiante.CodEstudiante};{estudiante.Nombre};{estudiante.Edad};{estudiante.Carrera}");
            }

            writer.WriteLine($"{nEstudiante.CodEstudiante};{nEstudiante.Nombre};{nEstudiante.Edad};{nEstudiante.Carrera}");
            writer.Close();

            LeerEstudiantes();
        }

        static void MostrarEstudiantes() {
            Console.WriteLine("Lista de Estudiantes:");
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine($"Codigo: {estudiante.CodEstudiante} - Nombre: {estudiante.Nombre} - Edad: {estudiante.Edad} - Carrera: {estudiante.Carrera}");
            }
        }

        static void LeerEstudiantes() { 
            estudiantes.Clear();
            StreamReader reader = new StreamReader(dirEstudiantes);
            do
            {
                string[] line = reader.ReadLine().Split(";");
                Estudiante estudiante = new Estudiante();
                estudiante.CodEstudiante = line[0];
                estudiante.Nombre = line[1];
                estudiante.Edad = line[2];
                estudiante.Carrera = line[3];

                estudiantes.Add(estudiante);
            } while(reader.Peek() != -1);
            reader.Close();
        }
    }
}
