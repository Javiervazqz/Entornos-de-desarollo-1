namespace Avion
{
    internal class Avion
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// Represents an airplane with altitude, velocity, fuel, and orientation properties.
        /// </summary>
        public class AvionClass
        {
            private float Altura;
            private float Velocidad; // Velocidad del avión
            private float Combustible;
            private int Orientacion;

            /// <summary>
            /// Initializes a new instance of the <see cref="AvionClass"/> class with the specified altitude, velocity, fuel, and orientation.
            /// </summary>
            /// <param name="altura">The altitude of the airplane.</param>
            /// <param name="velocidad">The velocity of the airplane.</param>
            /// <param name="combustible">The amount of fuel the airplane has.</param>
            /// <param name="orientacion">The orientation of the airplane in degrees.</param>
            public AvionClass(float altura, float velocidad, float combustible, int orientacion)
            {
                this.Altura = altura;
                this.Velocidad = velocidad;
                this.Combustible = combustible;
                this.Orientacion = orientacion;
            }

            /// <summary>
            /// Gets the current altitude of the airplane.
            /// </summary>
            /// <returns>The altitude of the airplane.</returns>
            public float GetAltura()
            {
                return Altura;
            }

            /// <summary>
            /// Gets the current orientation of the airplane.
            /// </summary>
            /// <returns>The orientation of the airplane in degrees.</returns>
            public int GetOrientacion()
            {
                return Orientacion;
            }

            /// <summary>
            /// Changes the orientation of the airplane by the specified number of degrees.
            /// </summary>
            /// <param name="grados">The number of degrees to turn the airplane.</param>
            public void Virar(int grados)
            {
                Orientacion = (Orientacion + grados) % 360;
                ConsumirFuel(grados * 0.1f);
            }

            /// <summary>
            /// Gets the remaining fuel of the airplane.
            /// </summary>
            /// <returns>The amount of fuel remaining.</returns>
            public float GetCombustible()
            {
                return Combustible;
            }

            /// <summary>
            /// Ascends the airplane by the specified number of meters.
            /// </summary>
            /// <param name="metros">The number of meters to ascend.</param>
            public void Ascender(float metros)
            {
                Altura = Altura + metros;
                ConsumirFuel(metros * 0.3f);
            }

            /// <summary>
            /// Descends the airplane by the specified number of meters.
            /// </summary>
            /// <param name="metros">The number of meters to descend.</param>
            public void Descender(float metros)
            {
                Altura = Altura - metros;
                if (Altura < 0)
                    Altura = 0;
            }

            /// <summary>
            /// Consumes the specified amount of fuel.
            /// </summary>
            /// <param name="litros">The amount of fuel to consume in liters.</param>
            private void ConsumirFuel(float litros)
            {
                Combustible = Combustible - litros;
                if (Combustible < 0)
                    Combustible = 0;
            }
        }
    }
}