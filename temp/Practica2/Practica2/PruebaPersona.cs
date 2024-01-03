namespace Practica2
{
    internal class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("juan", 32);
            Persona p2 = new PersonaInglesa();
            p.Saludar();
            p2.Saludar();
        }
    }
}