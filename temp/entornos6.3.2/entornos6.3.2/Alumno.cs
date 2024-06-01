using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Alumno
    {
        private string nombre;
        private int nota;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != null && value.Length > 1)
                    Nombre = value;
            }
        }
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }
        public bool Aprobado
        {
            get
            {
                return nota >= 5;
            }
        }

        public Alumno()
        {

        }

        public Alumno(string nombre, int nota)
        {
            if (nombre != null && nombre.Length > 1 && nota < 11 && nota > -1)
            {
                this.nombre = nombre;
                this.nota = nota;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Nota: {nota}, Aprobado: {Aprobado}";
        }
    }

    public class Alumnos
    {
        private ArrayList listaAlumnos = new ArrayList();
        public int Count => listaAlumnos.Count;

        public int Longitud()
        {
            return listaAlumnos.Count;
        }

        public string MostrarAlumnos()
        {
            string resultado = "";
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (i == 0)
                {
                    resultado = listaAlumnos[i].ToString();
                }
                else
                {
                    resultado += $", {listaAlumnos[i]}";
                }
            }
            return resultado;
        }

        public void Agregar(Alumno alumno)
        {
            if (alumno != null)
                listaAlumnos.Add(alumno);
        }

        public Alumno Obtener(int indice)
        {
            if (listaAlumnos.Count == 0 || indice < 0 || indice >= listaAlumnos.Count)
            {
                return null;
            }
            return (Alumno)listaAlumnos[indice];
        }

        public float Media
        {
            get
            {
                if (listaAlumnos.Count == 0)
                {
                    return 0;
                }
                float sumaNotas = 0;
                foreach (Alumno alumno in listaAlumnos)
                {
                    sumaNotas += alumno.Nota;
                }
                return sumaNotas / listaAlumnos.Count;
            }
        }
    }
}

