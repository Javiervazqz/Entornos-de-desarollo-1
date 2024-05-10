using entornos63;

namespace TestReserva
{
    [TestFixture]
    public class TestReservas
    {
        // Pruebas para NIF válido e inválido
        [Test]
        public void TestNifValido([Values("12345678F", "12345678C", "12345678B", "12345678T", "12345678E", "12345678G")] string nif)
        {
            var reserva = new Reserva { Nif = nif };
            Assert.IsTrue(reserva._nifVal);
        }

        [Test]
        public void TestNumPlazasValido([Range(1, 50)] int numPlazas)
        {
            var reserva = new Reserva { NumPlazas = numPlazas };
            Assert.IsTrue(reserva._plazasVal);
        }

        [Test]
        public void TestReservaCompleta([Values("12345678A", "12345678B", "12345678C", "12345678D", "12345678E", "12345678F")] string nif, [Range(1, 50)] int numPlazas)
        {
            var reserva = new Reserva
            {
                Nif = nif,
                NumPlazas = numPlazas
            };

            Assert.IsTrue(reserva._nifVal && reserva._plazasVal);
        }

        [Test]
        public void TestNumPlazasInvalido([Values(0, -1, 51, 800)] int numPlazas)
        {
            var reserva = new Reserva { NumPlazas = numPlazas };
            Assert.IsFalse(reserva._plazasVal);
        }

        [Test]
        public void TestNifInvalido([Values("A12345678", "123456789", "", null, "12345678", "12345678AA", "1234$678A")] string nif)
        {
            var reserva = new Reserva { Nif = nif };
            Assert.IsFalse(reserva._nifVal);
        }     
    }
}