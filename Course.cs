using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    internal class Course
    {
        public Course(string name, string duration) {
            
            Name = name;
            Duration = duration;

        }

        public string Name { get; private set; }

        public string Duration { get; private set; }


        public void ShowCourseInformation()
        {
            Console.WriteLine($"{Name} \t\t-\t Duracion: {Duration}");
            
        }

    }
}
