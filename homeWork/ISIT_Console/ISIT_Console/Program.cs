using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace ISIT_Console
{
    class Program
    {
        private static void Main(string[] args)
        {
            var ISIT = new Institute();
            ISIT.Students = new List<Student>
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Specialty = "СИИ"
                },
                new Student
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                    Specialty = "СИИ"
                },
                new Student
                {
                    FirstName = "Петр",
                    LastName = "Петров",
                    Specialty = "ИС"
                },
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Салов",
                    Specialty = "ВТ"
                },
                new Student
                {
                    FirstName = "Степан",
                    LastName = "Степанов",
                    Specialty = "СИИ"
                },
                new Student
                {
                    FirstName = "Имя",
                    LastName = "Фамильев",
                    Specialty = "СИИ"
                },
                new Student
                {
                    FirstName = "Лев",
                    LastName = "Львов",
                    Specialty = "СИИ"
                },
            };
            ISIT.PollStudentToDeveloper();

            var Graduates = new List<Graduate>
            {
                new Graduate
                {
                    FirstName = "Выпускник",
                    LastName = "Выпускнов",
                    GraduationDate = new DateTime(),
                    Institute = ISIT
                },
                new Graduate
                {
                    FirstName = "Коля",
                    LastName = "Барабанов",
                    GraduationDate = new DateTime(),
                    Institute = ISIT
                },
            };

            foreach (var grad in Graduates)
            {
                if (grad.IsWantEnterDeveloper())
                {
                    ISIT.Manager.AcceptRequestEnter(grad, ISIT);
                }
            }

            ISIT.Session();
            ISIT.Session();
            ISIT.Session();
            Console.ReadLine();
        }
    }
}
