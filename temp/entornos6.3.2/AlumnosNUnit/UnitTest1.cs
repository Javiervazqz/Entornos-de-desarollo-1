using ConsoleApp1;
using NUnit.Framework;

namespace TestAlumno
{
    [TestFixture]
    public class TestAlumno
    {
        [Test]
        public void TestAgregarYObtener_Alumno_ConDatosValidos([Values("Javi", "Ana", "Luis")]
        string nombre, [Range(0, 10)] int nota)
        {
            var alumnos = new Alumnos();
            var alumno = new Alumno(nombre, nota);
            alumnos.Agregar(alumno);

            Assert.AreEqual(alumno, alumnos.Obtener(0));
            Assert.AreEqual(1, alumnos.Longitud());
            Assert.AreEqual(nota, alumnos.Media);
        }

        [Test]
        public void TestObtener_Alumno_ConIndiceInvalido_DebeRetornarNull([Values(-1, 1, 100)]
        int indice)
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno("Javi", 5));

            Assert.IsNull(alumnos.Obtener(indice));
        }

        [Test]
        public void TestListaVacia_Operaciones_DebeRetornarValoresEsperados()
        {
            var alumnos = new Alumnos();
            Assert.IsNull(alumnos.Obtener(0));
            Assert.AreEqual(0, alumnos.Longitud());
            Assert.AreEqual(0, alumnos.Media);
            Assert.IsEmpty(alumnos.MostrarAlumnos());
        }

        [Test]
        public void TestAgregarMultiples_Alumnos_VerificarMediaYLongitud()
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno("Javi", 8));
            alumnos.Agregar(new Alumno("Josemi", 6));

            float expectedMedia = (8 + 6) / 2.0f;
            Assert.AreEqual(expectedMedia, alumnos.Media, 0.01);
            Assert.AreEqual(2, alumnos.Longitud());
        }

        [Test]
        public void TestMostrarAlumnos_DebeRetornarCadenaCorrecta()
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno("Juan", 8));
            alumnos.Agregar(new Alumno("Ana", 9));

            var resultado = alumnos.MostrarAlumnos();
            Assert.AreEqual("Juan, Nota: 8, Ana, Nota: 9", resultado);
        }

        [Test]
        public void TestNota_Validacion([Range(0, 10)] int notaValida, [Values(-1, 11, 100)]
        int notaInvalida)
        {
            Alumno alumnoValido = new Alumno();
            Alumno alumnoInvalido = new Alumno();

            alumnoValido.Nota = notaValida;
            alumnoInvalido.Nota = notaInvalida;

            Assert.AreEqual(notaValida, alumnoValido.Nota);
            Assert.AreNotEqual(notaInvalida, alumnoInvalido.Nota);
        }

        [Test]
        public void TestAprobacion([Range(0, 10)] int nota)
        {
            Alumno alumno = new Alumno();
            alumno.Nota = nota;
            bool esAprobado = nota >= 5;
            Assert.AreEqual(esAprobado, alumno.Aprobado);
        }

        [Test]
        public void TestNombre([Values(null, "Juan", "Ana")] string nombre)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = nombre;
            Assert.AreEqual(nombre, alumno.Nombre);
        }

        [Test]
        public void TestLongitud_CuandoListaEstaVacia_DebeRetornarCero()
        {
            var alumnos = new Alumnos();
            Assert.AreEqual(0, alumnos.Longitud(), "La longitud debe ser 0 cuando la lista está vacía.");
        }

        [Test]
        public void TestLongitud_DebeRetornarUnoCuandoHayUnAlumno()
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno { Nombre = "Juan", Nota = 8 });
            Assert.AreEqual(1, alumnos.Longitud(), "La longitud debe ser 1 cuando hay un alumno.");
        }

        [Test]
        public void TestLongitud_DebeRetornarNumeroCorrectoDeAlumnosCuandoHayVarios()
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno { Nombre = "Juan", Nota = 8 });
            alumnos.Agregar(new Alumno { Nombre = "Ana", Nota = 9 });
            Assert.AreEqual(2, alumnos.Longitud(), "La longitud debe reflejar el número correcto de alumnos en la lista.");
        }

        [Test]
        public void TestMostrarAlumnos_DebeRetornarCadenaVaciaCuandoListaEstaVacia()
        {
            var alumnos = new Alumnos();
            var resultado = alumnos.MostrarAlumnos();
            Assert.IsEmpty(resultado, "La cadena debe estar vacía cuando no hay alumnos.");
        }

        [Test]
        public void TestMostrarAlumnos_DebeRetornarCadenaCorrectaCuandoHayUnAlumno()
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno { Nombre = "Juan", Nota = 8 });
            var resultado = alumnos.MostrarAlumnos();
            Assert.AreEqual("Juan, Nota: 8", resultado, "La cadena debe contener la información del alumno cuando hay uno en la lista.");
        }

        [Test]
        public void TestMostrarAlumnos_DebeRetornarCadenaCorrectaCuandoHayVariosAlumnos()
        {
            var alumnos = new Alumnos();
            alumnos.Agregar(new Alumno { Nombre = "Juan", Nota = 8 });
            alumnos.Agregar(new Alumno { Nombre = "Ana", Nota = 9 });
            var resultado = alumnos.MostrarAlumnos();
            Assert.AreEqual("Juan, Nota: 8, Ana, Nota: 9", resultado, "La cadena debe contener la información de todos los alumnos cuando hay varios.");
        }
    }
}
