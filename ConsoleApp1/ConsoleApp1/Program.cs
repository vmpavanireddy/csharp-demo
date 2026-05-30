//c#
//OOP-Object Oriented Programming
//Class-Blueprint of an object
//Object-Instance of a class
//Encapsulation-Hiding the internal details of an object and only exposing a public interface
//Inheritance-Ability of a new class to inherit properties and methods from an existing class
//Polymorphism-Ability of an object to take on many forms, allowing for method overriding and method overloading
//Abstraction-Hiding the complex implementation details and showing only the necessary features
using System;
//Classes and Objects
//Create a Class
class Car 
{
  string color = "red";
  //
  static void Main(string[] args)
  {
    //Create an Object
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
