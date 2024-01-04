using System;

namespace Practica3
{
    public class Operaciones
    {
        protected int valor1, valor2, resultado;
        public int GetValor1()
        {
            return valor1;
        }
        public void SetValor1(int value)
        {
            valor1 = value;
        }
        public int GetValor2()
        {
            return valor2;
        }
        public void SetValor2(int value)
        {
            valor2 = value;
        }
        public void SetResultado(int value)
        { 
            resultado = value;
        }
        public int GetResultado()
        { 
            return resultado; 
        }
        public virtual void Operar()
        {

        }
    }
}
