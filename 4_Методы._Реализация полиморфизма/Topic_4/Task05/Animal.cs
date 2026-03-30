using System;
namespace Task05
{
    public abstract class Animal
    {
        public abstract void MakeSound();
        public virtual void Sleep()
        {
            Console.WriteLine("Животное спит на животе.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Мяу-мяу!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Животное спит на боку.");
        }
    }
}

