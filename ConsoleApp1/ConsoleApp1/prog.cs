using System;

namespace MyApplication
{
  //multiple classes
  class Fav
  {
    //class attributes
    //field
    //syntax: access-modifier data-type variable-name = value;
    public string color = "green";
    //method
    //syntax: access-modifier return-type method-name(parameters)
    //method body
    //method without parameters
    //method without return type
    //method without parameters and return type
    //method without parameters but with return type
    //method with parameters but without return type
    //method with parameters and return type
    //method without parameters and return type
    public void MyMethod()
    {      
      Console.WriteLine("Welcome to C# programming");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Fav myObj = new Fav();
      Console.WriteLine(myObj.color);
      myObj.MyMethod();
    }
  }
  class Car 
  {
    string color = "red";
    //
    static void Main(string[] args)
    {
      //Create an Object
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
      //multiple objects
      Car myObj2 = new Car();
      Console.WriteLine(myObj2.color);
    }
  }
}
