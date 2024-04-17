using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    internal class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string Email { get; set; }
        private List<Course> SelectedCourses { get; set; } = new List<Course>();


        public Student()
        {

        }
        public void SetFirstName(string tFirstName)
        {
            FirstName = tFirstName;
        }
        public void SetLastName(string tLastName)
        {
            LastName = tLastName;
        }

        public void SetAge(int tAge)
        {
            Age = tAge;
        }

        public void SetEmail(string tEmail)
        {
            Email = tEmail;
        }

        public void SetCourses(Course course)
        {
            SelectedCourses.Add(course);
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetEmail()
        {
            return Email;
        }

        private void SetStudentData()
        {
            try
            {

                Console.WriteLine("Ingrese Nombre:");
                SetFirstName(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese su Apellido:");
                SetLastName(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese su edad:");
                SetAge(int.Parse(Console.ReadLine()));
                Console.Clear();

                Console.WriteLine("Ingrese su correo electronico:");
                SetEmail(Console.ReadLine());
                Console.Clear();
            }

            catch (FormatException) 
            {
                Console.WriteLine(Constants.FormatErrorMessage);
            }
        }

        private void ShowStudentData() 
        {
            Console.WriteLine($"Nombre: { GetFirstName()} { GetLastName()}");
            Console.WriteLine("Edad: " + GetAge());
            Console.WriteLine("Email: " + GetEmail());
        }

        public void SignUp()
        {

                char reply = 'S';

                do
                {
                    SetStudentData();
                    Console.WriteLine("--- Datos del alumno ---");
                    ShowStudentData();
                    Console.WriteLine("¿Los datos son correctos? - 'S' para confirmar, ingrese cualquier otro caracter para volver a cargar los datos");

                    reply = char.Parse(Console.ReadLine());

                } while (reply != 's' && reply != 'S');

        }
        public void SignUpToCourse(List<Course> availableCourses)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el curso al que desea inscribirse");

            for (int i = 0; i < availableCourses.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                availableCourses[i].ShowCourseInformation();
            }
            try
            {
                if (int.TryParse(Console.ReadLine(), out int courseNumber) && courseNumber >= 1 && courseNumber <= availableCourses.Count)
                {
                    SetCourses(availableCourses[courseNumber - 1]);
                    Console.WriteLine("Curso seleccionado: " + availableCourses[courseNumber - 1].Name);
                }
                else
                {
                    Console.WriteLine("El número ingresado no corresponde a ningún curso disponible.");
                }
            } 
            
            catch (FormatException)
            {
                Console.WriteLine(Constants.FormatErrorMessage);
            }
        }
        public void ShowInscriptions()
        {
            Console.WriteLine("<<< Constancia de inscripción >>>");
            ShowStudentData();
            Console.WriteLine("Cursos en los que esta inscripto: ");
            ShowCourses();

        }

        public void ShowCourses()
        {
            foreach (var course in SelectedCourses)
            {
                course.ShowCourseInformation();
            }
        }
    }
}
