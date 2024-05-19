namespace Cuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aquí podrías agregar el código de prueba para la clase Cuenta
        }

        /// <summary>
        /// Clase que representa una cuenta bancaria.
        /// </summary>
        public class Cuenta
        {
            /// <summary>
            /// Saldo actual de la cuenta.
            /// </summary>
            private double Saldo { get; set; }

            /// <summary>
            /// Obtiene el saldo actual de la cuenta.
            /// </summary>
            /// <value>El saldo actual de la cuenta.</value>
            public double ConsultarSaldo => Saldo;

            /// <summary>
            /// Inserta una cantidad en el saldo de la cuenta.
            /// </summary>
            /// <param name="cantidad">La cantidad a insertar en el saldo.</param>
            /// <example>
            /// <code>
            /// Cuenta miCuenta = new Cuenta();
            /// miCuenta.InsertarSaldo(100.0);
            /// </code>
            /// </example>
            public void InsertarSaldo(double cantidad)
            {
                Saldo += cantidad;
            }

            /// <summary>
            /// Retira una cantidad del saldo de la cuenta.
            /// </summary>
            /// <param name="cantidad">La cantidad a retirar del saldo.</param>
            /// <example>
            /// <code>
            /// Cuenta miCuenta = new Cuenta();
            /// miCuenta.InsertarSaldo(100.0);
            /// miCuenta.RetirarSaldo(50.0);
            /// </code>
            /// </example>
            public void RetirarSaldo(double cantidad)
            {
                Saldo -= cantidad;
            }
        }
    }
}
