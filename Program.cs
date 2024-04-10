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
                new Course("Diseño Web Responsive", "2 Meses")
            };


        student.signUp();
        student.signUpToCourse(courses);                           
        student.showInscriptions();
       

     

        
    }
}
