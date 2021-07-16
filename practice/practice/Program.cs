using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mikah = new Person("Mikah",21,true,12);
            

            Console.WriteLine(mikah.Bday());
            Console.WriteLine(mikah.Bday());
            Console.WriteLine(mikah.name + " has $" + mikah.AcountBalance());
        }
    }
    class Class1
    {
        protected int a, b;
        public Class1()
        {
            a = 0;
            b = 0;
            Console.WriteLine("Inside base class default constructor");
        }
        public Class1(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Inside base class parameterized constructor");
        }
    }
    class Class2 : Class1
    {
        int c;
        public Class2(int a, int b, int c) : base(a, b)
        {
            this.c = c;
            Console.WriteLine("Inside derived class parametrized constructor");
        }
    }

}
