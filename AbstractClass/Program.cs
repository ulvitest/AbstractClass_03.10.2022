using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Userclass
            //User user = new User();
            //user.Name = "Lorem";
            //user.Surname = "Ipsum";

            //User user1 = new User();
            //user1.Name = "Lorem1";
            //user1.Surname = "Ipsum1";

            //int[] numbers = { 1, 2, 3 };

            //string[] word = {"lorem","ipsum"};

            //User[] users = {user,user1,new User("Lorem2","Ipsum2"), new User("David", "Qayibov"),new User() };

            //foreach (var item in users)
            //{
            //    item.Info();
            //}
            #endregion

            //1.instance yaratmaq olmur;
            //Animal animal = new Animal();

            Eagle eagle = new Eagle();
            // eagle.Eat();
            //eagle.Fly();
            //eagle.Test();

            Shark shark = new Shark();
            //shark.Swim();
            Animal[] arr = { eagle,shark };
            foreach (var item in arr)
            {
                item.Eat();
            }



        }
    }
}
