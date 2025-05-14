using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQTest
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsOniiSan { get; set; }

        public Student(string name, int age, bool isOniiSan)
        {
            Name = name;
            Age = age;
            IsOniiSan = isOniiSan;
        }
    }
}
