namespace Practica2
{
    internal class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.SetAge(24);
            p.SetName("jose");
            p.Saludar();
            Persona p2 = new PersonaInglesa();
            p2.SetAge(24);
            p2.SetName("juan");
            p2.Saludar();
        }
    }
}