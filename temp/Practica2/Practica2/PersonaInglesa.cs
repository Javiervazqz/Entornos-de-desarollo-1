using System;

namespace Practica2
{
    public class PersonaInglesa : Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Hi im " + GetName() + " and i have " + GetAge());
        }
    }
}
