using NUnit.Framework;
using Práctica6._3_;

namespace TestReserva
{
    [TestFixture]
    public class TestReservas
    {
        [Test]
        public void TestValidaIdentificacion([Values("12345678A", "12345678B", "12345678C", "12345678D", "12345678E", "12345678F")] string id)
        {
            var reserva = new Reserva { Identificacion = id };
            Assert.IsTrue(reserva.IdentificacionValida);
        }

        [Test]
        public void TestInvalidaIdentificacion([Values("A12345678", "123456789", "", null, "12345678", "12345678AA", "1234$678A")] string id)
        {
            var reserva = new Reserva { Identificacion = id };
            Assert.IsFalse(reserva.IdentificacionValida);
        }

        [Test]
        public void TestValidaCantidadAsientos([Range(1, 50)] int cantAsientos)
        {
            var reserva = new Reserva { CantidadAsientos = cantAsientos };
            Assert.IsTrue(reserva.AsientosValidos);
        }

        [Test]
        public void TestInvalidaCantidadAsientos([Values(0, -1, 51, 100)] int cantAsientos)
        {
            var reserva = new Reserva { CantidadAsientos = cantAsientos };
            Assert.IsFalse(reserva.AsientosValidos);
        }

        [Test]
        public void TestReservaCompleta([Values("12345678A", "12345678B", "12345678C", "12345678D", "12345678E", "12345678F")] string id,
                                         [Range(1, 50)] int cantAsientos)
        {
            var reserva = new Reserva
            {
                Identificacion = id,
                CantidadAsientos = cantAsientos
            };

            Assert.IsTrue(reserva.IdentificacionValida && reserva.AsientosValidos);
        }
    }
}
