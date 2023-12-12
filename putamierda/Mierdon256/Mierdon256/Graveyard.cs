using System;

namespace Mierdon256
{
    public class Graveyard
    {
        private List<Person> _personList = new List<Person>();

        public int PersonCount
        {
            get
            {
                return _personList.Count;
            }
        }
    }
}
