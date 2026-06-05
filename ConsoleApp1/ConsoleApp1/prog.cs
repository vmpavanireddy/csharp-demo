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
    public string food;
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
      //accessing class attributes
      //accessing field
      //syntax: object-name.field-name
      Console.WriteLine(myObj.color);
      //leave the fields blank, and modify them when creating the object:
      myObj.food = "pizza";
      Console.WriteLine(myObj.food);
      //object method
      //syntax: object-name.method-name()
      //note that the method must be public to be accessible from outside the class
      //name of the method followed by two parentheses () and a semicolon ; to call (execute) the method
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
