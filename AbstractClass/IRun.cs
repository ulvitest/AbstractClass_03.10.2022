using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
     interface IRun
    {
        void Run();
        public void Test()
        {

        }
    }
    interface IEat
    {
        void Eat();
    }

    interface IWork
    {
        void Work();
    }
    class Person : IRun,IWork
    {

        public void Run()
        {
            Console.WriteLine("run as person");
        }

        public void Work()
        {
            Console.WriteLine("") ;
        }
    }

    class Robot : IWork,IEat
    {
       

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
