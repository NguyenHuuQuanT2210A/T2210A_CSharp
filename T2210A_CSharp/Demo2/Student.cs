using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.Demo2
{
    public class Student
    {
        public string name;
        public int age;
        public string telephone;

        public Student() {
            this.Eat();
        }

        //Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get => age;
            set { age = value >= 18 ? value : 18; }
        }
        public string Telephone
        {
            get => telephone;
            set { telephone = value; }
        }

        //Abstract property 
        public int Balance
        {
            get ; set;
        }

        public void Eat()
        {

        }
        public void Eat(string msg)
        {

        }
    }
}
