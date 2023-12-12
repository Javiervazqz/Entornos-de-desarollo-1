using System;

namespace Mierdon256
{
    public enum Gender
    {
        MALE,
        FEMALE,
        OTHER
    }
    public class Person
    {
        public string name;
        public Gender gender;
        public int[] array;
        public Person() : this ("Javi", Gender.FEMALE) //se invoca a otro constructor desde este constructor
        {

        }
        public Person(string name, Gender gender)
        {
            this.name = name;
            this.gender = gender;
            int arrayindex = 10;
            this.array = new int[arrayindex];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
    }
}
