using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    public class Person : BankAccount
    {
        public string name;
        public int Age { get; set; }
        public bool HasPet;

        public Person(string name, int age, bool hasPet, int balance) : base(balance)
        {
            this.name = name;
        
            HasPet = hasPet;
        }

        public void Greeting()
        {
            Console.WriteLine("Hello");
        }

        public int Bday()
        {
            Age++;
            return Age;
        }
    }
}
