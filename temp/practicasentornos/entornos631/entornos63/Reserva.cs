namespace Práctica6._3_
{
    public class Reserva
    {
        private string _identificacion;
        private int _cantidadAsientos;

        public bool IdentificacionValida { get; set; }
        public bool AsientosValidos { get; set; }

        public Reserva()
        {

        }

        public string Identificacion
        {
            get => _identificacion;
            set
            {
                _identificacion = value;
                IdentificacionValida = ValidarIdentificacion(_identificacion);
            }
        }

        public int CantidadAsientos
        {
            get => _cantidadAsientos;
            set
            {
                _cantidadAsientos = value;
                AsientosValidos = ValidarCantidadAsientos(_cantidadAsientos);
            }
        }

        public Reserva(string identificacion, int cantidadAsientos)
        {
            Identificacion = identificacion;
            CantidadAsientos = cantidadAsientos;
        }

        private bool ValidarIdentificacion(string identificacion)
        {
            if (string.IsNullOrWhiteSpace(identificacion) || identificacion.Length != 9 || !char.IsLetter(identificacion[^1]) || !char.IsUpper(identificacion[^1]))
            {
                return false;
            }

            for (int i = 0; i < identificacion.Length - 1; i++)
            {
                if (!char.IsDigit(identificacion[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidarCantidadAsientos(int cantidadAsientos)
        {
            return cantidadAsientos > 0 && cantidadAsientos <= 50;
        }
    }
}

