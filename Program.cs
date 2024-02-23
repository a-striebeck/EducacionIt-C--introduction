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
        string errorMessage = "Datos incorrectos. Ejecutar nuevamente la aplicación";
        char reply;
        int careerCode;

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
            Console.WriteLine("Ingrese el codigo de la carrera: ");
            Console.WriteLine("1. Programacion .NET");
            Console.WriteLine("2. Programacion Java");
            Console.WriteLine("3. Programacion PHP");
            careerCode = int.Parse(Console.ReadLine());
            if (careerCode == 1 || careerCode == 2|| careerCode == 3)
            {
                Console.WriteLine("--- Constancia de inscripción ---");
                Console.WriteLine("Alumno: "+ name + " " + lastName );
                Console.WriteLine("Correo Electronico: "+ Email);
                switch (careerCode)
                {
                    case 1:
                        Console.WriteLine("Carrera: Programacion .NET");
                        break;
                    case 2:
                        Console.WriteLine("Carrera: Programacion Java");
                        break;
                    case 3:
                        Console.WriteLine("Carrera: Programacion PHP");
                        break;
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
            
        }
        else{
            Console.WriteLine(errorMessage);
        }
        
    }
}
