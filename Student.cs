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
        public List<string> SelectedCourses { get; private set; } = new List<string>();


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

        public void setCourses(string courses)
        {
            SelectedCourses.Add(courses);
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

        public void signUpToCourse(string[] availableCourses)
        {
            int careerCode = 0;
            char reply = 'S';

            do { 
                Console.Clear();
                Console.WriteLine("Ingrese el curso al que desea inscribirse");

                foreach (var course in availableCourses)
                {
                    Console.WriteLine(course);
                }

                careerCode = int.Parse(Console.ReadLine());

                if (careerCode >= 1 && careerCode <= 5)

                {
                    setCourses(availableCourses[careerCode - 1]);
                    Console.WriteLine("Curso seleccionado: " + availableCourses[careerCode - 1]);
                    Console.WriteLine("¿Desea seleccionar otro curso? - 'S' para sí, 'N' para no");
                    reply = char.Parse(Console.ReadLine());
                }

            }   while (reply == 's' && reply == 'S');

        }
        public void showInscriptions()
        {
            Console.WriteLine("<<<Constancia de inscripción>>>");
            Console.WriteLine("Alumno: " + Name + " " + LastName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("--- Cursos seleccionados ---");

            foreach (var course in SelectedCourses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
