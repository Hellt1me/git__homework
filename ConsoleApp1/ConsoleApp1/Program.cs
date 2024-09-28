using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    

        public class Student
        {

            public string FullName { get; set; }
            public string Group { get; set; }
            public double AverageGrade { get; set; }


            public Student(string fullName, string group, double averageGrade)
            {
                FullName = fullName;
                Group = group;
                AverageGrade = averageGrade;
            }


            public virtual double GetScholarship()
            {
                return AverageGrade == 5 ? 2000 : 1900;
            }
        }

        public class Aspirant : Student
        {

            public string ScientificWork { get; set; }

            public Aspirant(string fullName, string group, double averageGrade, string scientificWork)
                : base(fullName, group, averageGrade)
            {
                ScientificWork = scientificWork;
            }


            public override double GetScholarship()
            {
                return AverageGrade == 5 ? 2500 : 2200;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Student student = new Student("Иванов Иван Иванович", "ИС-10", 4.5);
                Console.WriteLine($"Студент: {student.FullName}, Группа: {student.Group}, Стипендия: {student.GetScholarship()} руб.");


                Aspirant aspirant = new Aspirant("Петров Петр Петрович", "Аспирантура", 5, "Исследование инновационных технологий");
                Console.WriteLine($"Аспирант: {aspirant.FullName}, Группа: {aspirant.Group}, Научная работа: {aspirant.ScientificWork}, Стипендия: {aspirant.GetScholarship()} руб.");

                Console.ReadKey();
            }
        }
    }
