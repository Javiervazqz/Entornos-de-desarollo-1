namespace entornos63
{
    public class Reserva
    {
        private string _nif;
        private int _numPlazas;
        public bool _nifVal;
        public bool _plazasVal;
        public string Nif
        {
            get => _nif;
            set
            {
                _nif = value;
                _nifVal = ValidarNif(_nif);
            }
        }
        public int NumPlazas
        {
            get => _numPlazas;
            set
            {
                _numPlazas = value;
                _plazasVal = (_numPlazas > 0 && _numPlazas <= 50);
            }
        }

        public Reserva()
        {

        }

        public Reserva(string nif, int numPlazas)
        {
            Nif = nif;
            NumPlazas = numPlazas;
        }

        private bool ValidarNif(string nif)
        {
            if (!string.IsNullOrWhiteSpace(nif) || nif.Length == 9 || char.IsLetter(nif[^1]) || char.IsUpper(nif[^1]))
            {
                return true;
            }
            for (int i = 0; i < nif.Length - 1; i++)
            {
                if (!char.IsDigit(nif[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
