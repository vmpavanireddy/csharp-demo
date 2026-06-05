using System;

namespace HelloWorld
{
    //Inheritance
    //Inheritance is the process by which one class can inherit the properties and methods of another class. The class that inherits the properties and methods is called the derived class, and the class that is inherited from is called the base class. Inheritance allows you to create a new class that is a modified version of an existing class, which promotes code reusability and makes it easier to maintain and update your code.
    //In C#, a class can only inherit from one base class, but it can implement multiple interfaces. An interface is a contract that defines a set of methods and properties that a class must implement, but it does not provide any implementation for those methods and properties. An interface is used to define a common set of methods and properties that can be implemented by multiple classes, which promotes code reusability and makes it easier to maintain and update your code.
    //Syntax of inheritance in C#:
    //class derived-class-name : base-class-name
    //{
    //    //class body
    //}
    //Example of inheritance in C#:
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }

  class inheritance
  {
    static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.eat(); // calling the eat method from the base class
            myDog.bark(); // calling the bark method from the derived class
        }
  }
}
