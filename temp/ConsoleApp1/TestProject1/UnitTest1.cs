namespace ConsoleApp1
{
    [TestFixture] 
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestNotaValida1()
        {
            Alumno alumno1 = new Alumno();
            alumno1.Nota = 4;
            int esperado = 4;
            Assert.AreEqual(esperado, alumno1.Nota);
        }
        [Test]
        public void TestNotaNoValida1()
        {
            Alumno alu = new Alumno();
            alu.Nota = -120;
            int esperado = 0;
            Assert.AreEqual(esperado, alu.Nota);
        }
        [Test]
        public void TestNotaNoValida2()
        {
            Alumno alu = new Alumno();
            alu.Nota = 89;
            int esperado = 0;
            Assert.AreEqual(esperado, alu.Nota);
        }
        [Test]
        public void TestNotaValidaRango1([Range(0,10,1)] int nota)
        {
            var a = new Alumno();
            a.Nota = nota;
            Assert.AreEqual(nota, a.Nota);
        }
        [Test]
        public void TestNotaNoValidaRango1([Range(-10, 10, 1)] int nota)
        {
            var a = new Alumno();
            a.Nota = nota;
            Assert.AreEqual(nota, a.Nota);
        }
        [Test]
        public void MostrarAlumnos()
        {
            MostrarAlumnos();
        }
    }
}