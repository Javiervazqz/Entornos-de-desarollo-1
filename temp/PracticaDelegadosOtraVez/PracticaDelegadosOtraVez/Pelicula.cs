using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDelegadosOtraVez
{
    public class Pelicula
    {
        public string title;
        public string directorName;
        public int yearReleased;
        public Pelicula(string title, string directorName, int yearReleased)
        {
            this.title = title;
            this.directorName = directorName; 
            this.yearReleased = yearReleased;
        }
    }
}
