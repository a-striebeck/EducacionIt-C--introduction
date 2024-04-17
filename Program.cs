using System.Net.NetworkInformation;

namespace ProyectoIntegrador;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        List<Course> courses = new List<Course>
            {
                new Course("Programación .Net", "3 Meses"),
                new Course("Programación Java", "4 Meses"),
                new Course("Programación PHP", "3 Meses"),
                new Course("Programación C++", "5 Meses"),
                new Course("Diseño Web", "2 Meses")
            };


        student.SignUp();
        char reply;
        do
        {
            student.SignUpToCourse(courses);
            Console.WriteLine("¿Desea seleccionar otro curso? - 'S' para sí, 'N' para no");
            reply = char.ToUpper(Console.ReadKey().KeyChar);

        } while (reply == 'S');
        student.ShowInscriptions();
       

     

        
    }
}
