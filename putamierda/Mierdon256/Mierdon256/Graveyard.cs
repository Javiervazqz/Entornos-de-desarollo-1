using System;

namespace Mierdon256
{
    public class Graveyard
    {
        private List<Person> _personList = new List<Person>();

        public int PersonCount => GetPersonCount();
        public int GetPersonCount()
        {
            return _personList.Count;
        }
        //public int PersonCount
        //{
        //    get
        //    {
        //        return _personList.Count;
        //    }
        //}
        public Person? GetPersonAt(int index)
        {
            if (index == null)
                return null;
            for (int i = 0; i < _personList.Count; i++)
            {
                if (i == index)
                    return _personList[i];
            }
        }
        public void RemovePersonAt(int index)
        {
            _personList.RemoveAt(index);
        }
        public void AddPerson(Person person)
        {
            _personList.Add(person);
        }
    }
}
