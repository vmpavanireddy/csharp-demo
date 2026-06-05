using System;
namespace MyApplication
{
    class forconstructor
  {
    public string color;
    //constructor
    //syntax: access-modifier class-name(parameters)
    //constructor body
    //constructor without parameters
    //constructor with parameters
    //constructor without parameters but with default values
    //constructor with parameters and default values
    //note that the constructor must be public to be accessible from outside the class
    //note that the name of the constructor must be the same as the name of the class
    //note that the constructor does not have a return type, not even void
    //note that the constructor is called when an object of the class is created
    //note that if you do not create a constructor for a class, C# will automatically create a default constructor for you that will initialize all the fields to their default values.
    public forconstructor()
        {
            color = "pink";
        }
        public forconstructor(string color)
        {
            this.color = color;
        }
    static void Main(string[] args)
        {
            Console.WriteLine("Constructor without parameters");
            // Create an object of the Car Class (this will call the constructor)
            forconstructor myObj = new forconstructor();
            Console.WriteLine(myObj.color);
            //constructor with parameters
            Console.WriteLine("Constructor with parameters");
            forconstructor myObj2 = new forconstructor("red");
            Console.WriteLine(myObj2.color);
        }
  }
}