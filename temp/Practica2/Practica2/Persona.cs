using System;
namespace Practica2
{
    public class Persona
    {
        private string name;
        private int age;
        public string GetName() => name;
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAge() => age;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public virtual void Saludar()
        {
            Console.WriteLine("Hola soy " + name + " y tengo " + age + " anos");
        }
    }
}
