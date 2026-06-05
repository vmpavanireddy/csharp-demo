using System;

namespace HelloWorld
{
    //polymorphism
    //Polymorphism is the ability of an object to take on many forms. It allows you to use a single interface to represent different types of objects, which promotes code reusability and makes it easier to maintain and update your code. In C#, polymorphism is achieved through method overriding and method overloading.
    //example of polymorphism in C#:
    class Animals
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Dogs : Animals
    {
        public void eat()
        {
            Console.WriteLine("Eating dog food...");
        }
    }
    class Cat : Animals
    {
        public void eat()
        {
            Console.WriteLine("Eating cat food...");
        }
    }
  class poly
  {
    static void Main(string[] args)
        {
            Animals myAnimal = new Animals();
            myAnimal.eat(); // calling the eat method from the Animals class
            Dogs myDog = new Dogs();
            myDog.eat(); // calling the eat method from the Dogs class
            Cat myCat = new Cat();
            myCat.eat(); // calling the eat method from the Cat class
        }
  }
}