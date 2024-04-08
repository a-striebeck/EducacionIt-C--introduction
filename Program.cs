using System.Net.NetworkInformation;

namespace ProyectoIntegrador;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        string[] availableCourses = {"1. Programacion .Net", "2. Programacion Java", "3. Programacion PHP", "4. Programacion C++", "5. Diseño Web Responsive" };



        student.signUp();
        student.signUpToCourse(availableCourses);                           
        student.showInscriptions();
       

     

        
    }
}
