using System;

namespace Banco
{
    public class Cliente
    {
        private List<Cuenta> _cuentas = new List<Cuenta>();
        string nombre;
        string DNI;
        string direccion;
        int edad;
        public void CrearCuenta(long id)
        {
            Cuenta c = new Cuenta();
            _cuentas.Add(c);
        }
    }
}
