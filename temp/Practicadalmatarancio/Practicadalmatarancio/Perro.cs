using System;

namespace Practicadalmatarancio
{
    public class Perro
    {
        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Perro(string _name)
        {
            this._name = _name;
        }
        public Perro()
        {
            _name = "Mamahuevo";
        }
        public void Ladrar()
        {
            Console.WriteLine("au");
        }
        public virtual void ToString()
        {
            Console.WriteLine("Soy un perro y me llamo " + _name);
        }
    }
}
