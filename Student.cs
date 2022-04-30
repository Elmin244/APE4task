using System;
using System.Collections.Generic;
using System.Text;

namespace _30042022Hometask
{
    class Student
    {
        private static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        public double Point { get; set; }
        private Student()
        {
            _id++;
            Id = _id;
        }
        public Student(string fullName, double point) : this()
        {
            FullName = fullName;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($@"Id - {Id} Full Name -{FullName} Point - {Point}");
        }

    }
}
