using System.Net.NetworkInformation;

namespace ProyectoIntegrador;
/*Realizar un programa que solicite al alumno 
los siguientes datos:
● Nombre.
● Apellido.
● Edad.
● Correo electrónico.
*/
class Program
{
    static void Main(string[] args)
    {
        string name;
        string lastName;
        int age;
        string Email;
        List<string> selectedCourses = new List<string>();


        string errorMessage = "Datos incorrectos. Ejecutar nuevamente la aplicación";
        char reply;
        int careerCode;
        string[] availableCourses = {"1. Programacion .Net", "2. Programacion Java", "3. Programacion PHP", "4. Programacion C++", "5. Diseño Web Responsive" };

        Console.WriteLine("Ingrese Nombre:");
        name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Ingrese su Apellido:");
        lastName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Ingrese su edad:");
        age = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese su correo electronico:");
        Email = Console.ReadLine();

        Console.WriteLine("--- Datos del alumno ---");
        Console.WriteLine("Nombre: " + name);
        Console.WriteLine("Apellido: "+ lastName);
        Console.WriteLine("Edad: " + age);
        Console.WriteLine("Email: " + Email);

        Console.WriteLine("¿Los datos son correctos? - 'S' para confirmar 'N' para cancelar");
        reply = char.Parse(Console.ReadLine());

        if (reply == 's' || reply == 'S')
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el curso al que desea inscribirse");
                foreach (var course in availableCourses)
                {
                    Console.WriteLine(course);
                }
                careerCode = int.Parse(Console.ReadLine());
                if (careerCode >= 1 && careerCode <= 5)
                {
                    selectedCourses.Add(availableCourses[careerCode - 1]);
                    Console.WriteLine("Curso seleccionado: " + availableCourses[careerCode - 1]);
                    Console.WriteLine("¿Desea seleccionar otro curso? - 'S' para sí, 'N' para no");
                    reply = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(errorMessage);
                    reply = 'N';
                }
            } while (reply == 'S' || reply == 's');


            Console.WriteLine("Alumno: " + name + " " + lastName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("--- Cursos seleccionados ---");
            foreach (var course in selectedCourses)
            {
                Console.WriteLine(course);
            }
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
        
    }
}
