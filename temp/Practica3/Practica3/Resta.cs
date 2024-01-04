using System;

namespace Practica3
{
    public class Resta : Operaciones
    {
        public override void Operar()
        {
            SetResultado(valor1 - valor2);
        }
    }
}
