using System;

namespace HelloWorld
{
  class accessmodifiers
  {
    //access modifiers
    //access modifiers are keywords used to specify the accessibility of a class, method, or field
    //access modifiers are used to control the access to the members of a class
    //access modifiers are used to protect the members of a class from unauthorized access
    //access modifiers are used to specify the accessibility of a class, method, or field
    //access modifiers are used to control the access to the members of a class
    //access modifiers in C#
    //1. public: the member is accessible from anywhere in the program
    //2. private: the member is accessible only within the class
    //3. protected: the member is accessible within the class and its derived classes
    //4. internal: the member is accessible within the same assembly
    //access modifiers can be used in combination with each other to specify the accessibility of a class, method, or field
    //for example, a member can be declared as public and static, which means that it is accessible from anywhere in the program and can be accessed without creating an object of the class
    //note that if you do not specify an access modifier for a class, method, or field, it will be private by default
    //note that the access modifier must be specified before the data type of the member
    //note that the access modifier must be specified before the return type of the method
    //note that the access modifier must be specified before the name of the class, method, or field
    //example of access modifiers in C#
    public string sentence_1 = "This is a public field";
    private string sentence_2 = "This is a private field";
    protected string sentence_3 = "This is a protected field";
    internal string sentence_4 = "This is an internal field";   
    static void Main(string[] args)
        {
            accessmodifiers myObj = new accessmodifiers();
            Console.WriteLine(myObj.sentence_1);
            Console.WriteLine(myObj.sentence_2); //this will not give an error because sentence_2 is private and is in same class 
            Console.WriteLine(myObj.sentence_3); //this will not give an error because sentence_3 is protected and is in same class 
            Console.WriteLine(myObj.sentence_4); //this will not give an error because sentence_4 is internal and is in same assembly 
        }
  }
}
/*class Car
{
  private string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
If you try to access it outside the class, an error will occur:
'Car.model' is inaccessible due to its protection level
The field 'Car.model' is assigned but its value is never used
*/