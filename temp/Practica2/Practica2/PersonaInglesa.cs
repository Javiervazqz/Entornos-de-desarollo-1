using System;

namespace Practica2
{
    public class PersonaInglesa : Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Hi im " + GetName() + " and i have " + GetAge());
        }
        public PersonaInglesa()
        {
            name = "josetrixius";
            age = 19;
        }
        public PersonaInglesa(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
