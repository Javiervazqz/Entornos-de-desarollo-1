﻿using System;

namespace Mierdon256
{
    public enum Gender
    {
        MALE,
        FEMALE,
        OTHER
    }
    public abstract class Person
    {
        public string Name;
        public Gender gender;
        public int[] array;
        public Person() : this ("Javi", Gender.FEMALE) //se invoca a otro constructor desde este constructor
        {

        }
        public Person(string name, Gender gender)
        {
            this.Name = name;
            this.gender = gender;
            int arrayindex = 10;
            this.array = new int[arrayindex];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        public virtual string GetFullName()
        {
            return Name;
        }
        public abstract void ExecuteTurn();
        public void Metodo1()
        {

        }
        public void Metodo2()
        {

        }
        public void Metodo3()
        {

        }
        public void Metodo4()
        {

        }
        public void Metodo5()
        {

        }
    }
}
