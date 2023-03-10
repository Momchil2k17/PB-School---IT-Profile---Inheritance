using System;
using System.Collections.Generic;
using System.Text;

namespace PersonChildClass
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        
        public Person(string name,int age)
        { 
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }

    }
}
