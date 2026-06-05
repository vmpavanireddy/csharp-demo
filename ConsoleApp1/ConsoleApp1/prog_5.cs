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
  //overideing a method in the derived class is called method overriding, 
  // it is achieved by using the virtual keyword in the base class and the override keyword in the derived class.
  //  Method overloading is when you have multiple methods with the same name but different parameters in the same class.
  //  It is achieved by defining multiple methods with the same name but different parameters in the same class.
  //  example of method overloading in C#:
  class Math
  {
    public int Add(int a, int b)
    {
        return a + b;   
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;   
    }
  }
    class poly2
    {
        static void Main(string[] args)
            {
                Math myMath = new Math();
                //method overloading
                // calling the Add method with different parameters
                // the compiler will determine which method to call based on the number and type of parameters passed to the method
                //note that the method name is the same, but the parameters are different
                //note that the return type of the method is not considered when determining which method to call, only the number and type of parameters are considered
                //note that the method must be public to be accessible from outside the class
                //note that the method must be static to be called without creating an object of the class
                //note that the method must be called with the correct number and type of parameters to avoid a compile-time error
                //note that if you try to call the method with the wrong number or type of parameters, a compile-time error will occur
                //method overriding
                // calling the eat method from the Animals class, which is overridden in the Dogs and Cat classes
                Animals myAnimal = new Animals();
                myAnimal.eat(); // calling the eat method from the Animals class
                Dogs myDog = new Dogs();
                myDog.eat(); // calling the eat method from the Dogs class
                Cat myCat = new Cat();
                myCat.eat(); // calling the eat method from the Cat class
                //method overloading
                Console.WriteLine(myMath.Add(1, 2)); // calling the Add method with 2 parameters
                Console.WriteLine(myMath.Add(1, 2, 3)); // calling the Add method with 3 parameters
            }
    }

}