using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Animal
    {
        public int Age { get; set; }
        public Animal()
        {

        }

        public abstract void Eat();

        public virtual void Test()
        {
            Console.WriteLine("test");
        }
    }
    abstract class Bird : Animal
    {
        public abstract void Fly();

    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("eat as eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("fly as eagle");
        }

        public override void Test()
        {
            Console.WriteLine("test as eagle"); ;    
        }
    }

   abstract class Fish:Animal
    {

        public abstract void Swim();
    }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("eat as shark"); ;
        }

        public override void Swim()
        {
            Console.WriteLine("swim as shark");     
        }

        public override void Test()
        {
            Console.WriteLine("test as shark"); ;    
        }
    }


}
