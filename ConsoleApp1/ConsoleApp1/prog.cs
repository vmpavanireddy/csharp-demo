using System;

namespace MyApplication
{
  //multiple classes
  class Fav
  {
    public string color = "green";
  }
  class Program
  {
    static void Main(string[] args)
    {
      Fav myObj = new Fav();
      Console.WriteLine(myObj.color);
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
