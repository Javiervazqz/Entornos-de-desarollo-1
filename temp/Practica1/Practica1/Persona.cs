using System;

namespace Practica1
{
    public class Persona
    {
        public string name;
        public int birthyear;
        public Persona(string name, int birthyear)
        {
            this.name = name;
            this.birthyear = birthyear;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy " + name + " y naci en el " + birthyear);
        }
    }
}
