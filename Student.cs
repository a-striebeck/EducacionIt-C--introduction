using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    internal class Student
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
        public List<Course> SelectedCourses { get; private set; } = new List<Course>();


        public Student()
        {

        }
        public void setName(string tName)
        {
            Name = tName;
        }
        public void setLastName(string tLastName)
        {
            LastName = tLastName;
        }

        public void setAge(int tAge)
        {
            Age = tAge;
        }

        public void setEmail(string tEmail)
        {
            Email = tEmail;
        }

        public void setCourses(Course course)
        {
            SelectedCourses.Add(course);
        }


        public void signUp()
        {

            char reply = 'S';

            do
            {
                Console.WriteLine("Ingrese Nombre:");
                setName(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese su Apellido:");
                setLastName(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese su edad:");
                setAge(int.Parse(Console.ReadLine()));
                Console.Clear();

                Console.WriteLine("Ingrese su correo electronico:");
                setEmail(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("--- Datos del alumno ---");
                Console.WriteLine("Nombre: " + Name);
                Console.WriteLine("Apellido: " + LastName);
                Console.WriteLine("Edad: " + Age);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("¿Los datos son correctos? - 'S' para confirmar, ingrese cualquier otro caracter para volver a cargar los datos");

                reply = char.Parse(Console.ReadLine());

            }   while (reply != 's' && reply != 'S');
        }

        public void signUpToCourse(List<Course> availableCourses)
        {
            char reply = 'S';

            do { 
                Console.Clear();
                Console.WriteLine("Ingrese el curso al que desea inscribirse");

                for (int i = 0; i < availableCourses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableCourses[i].Name} - Duración: {availableCourses[i].Duration}");
                }

                if (int.TryParse(Console.ReadLine(), out int courseNumber) && courseNumber >= 1 && courseNumber <= availableCourses.Count)
                {
                    setCourses(availableCourses[courseNumber - 1]);
                    Console.WriteLine("Curso seleccionado: " + availableCourses[courseNumber - 1].Name);
                }
                else
                {
                    Console.WriteLine("El número ingresado no corresponde a ningún curso disponible.");
                }

                Console.WriteLine("¿Desea seleccionar otro curso? - 'S' para sí, 'N' para no");
                reply = char.ToUpper(Console.ReadKey().KeyChar);
                Console.Clear();
            } while (reply == 'S');

        }
        public void showInscriptions()
        {
            Console.WriteLine("<<< Constancia de inscripción >>>");
            Console.WriteLine($"Alumno: {Name} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("--- Cursos seleccionados ---");

            foreach (var course in SelectedCourses)
            {
                Console.WriteLine(course.Name);
                Console.WriteLine(course.Duration);
            }
        }
    }
}
