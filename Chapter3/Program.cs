using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Person{
        public string name;
        public int age;

        public void GetInfo() => Console.WriteLine("This person is {0}, he/she is {1} years old",name, age);

        //Constructor

        public Person(){name = "*undefined*"; age = 0;}
        public Person(string n){name = n; age=5;}
        public Person(string n, int a){name = n; age = a;}
        public Person(int a):this("SJ",a){}
    }

    struct Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void GetCoord()
        {
            Console.WriteLine($"X:{x}, Y:{y}");
        }
    }

    class Cat
    {
        public string Name { get; set; } = "NoName";
        private int age = 0;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value < 30)
                    age = value;
                else throw new Exception($"Incorrect age = {value}");
            }
        }
        public void GetInfo() => Console.WriteLine($"This cat nave name: {Name} and he is {Age} years old");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Alex = new Person();
            Alex.age = 20;
            Alex.name = "Alex";
            Alex.GetInfo();

            Console.ReadKey();

            Person Sweet = new Person("Sweet");
            Sweet.GetInfo();

            Console.ReadKey();

            Person Ryder = new Person("Ryder", 26);
            Ryder.GetInfo();

            Console.ReadKey();

            Person SJ = new Person(23);
            SJ.GetInfo();
            Console.ReadKey();
            Console.Clear();

            Point a = new Point(1,2);

            a.GetCoord();
            Console.Clear();
            Console.WriteLine("Now I want to make a realy good class with properties");
            Console.WriteLine("It will be class 'Cat'");
            Cat Ksusha = new Cat();
            Ksusha.Name = "Ksusha";
            Ksusha.Age = 4;
            Ksusha.GetInfo();
            Cat idk = new Cat();
            idk.Name = "idk";
            idk.GetInfo();
            Console.Write("Enter age (>=0 && <30) of idk: ");
            idk.Age = Convert.ToInt32(Console.ReadLine());
            idk.GetInfo();

        }
    }
}
