using System;

namespace HelloWorld
{
    class Program
    {
        //Properties and Encapsulation
        //Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
        //declare fields/variables as private
        //provide public get and set methods, through properties, to access and update the value of a private field
        ///property is like a combination of a variable and a method, and it has two methods: a get and a set method:
        //C# Properties (Get and Set)
        //A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
        //Properties can be used as if they are public data members, but they are actually special methods called accessors. This enables data to be accessed easily and still helps promote the safety and flexibility of methods.
        //A property can have two accessors: get and set.
        //  The get accessor returns the value of the property, and the set accessor assigns a new value to the property. The value keyword is used to define the value being assigned by the set accessor.
        //Syntax of a property:
        //access-modifier data-type property-name
        //{
        //    get { return field-name; }
        //    set { field-name = value; }
        //}
        //note that the name of the property must be the same as the name of the field, but with a capital letter at the beginning
        //note that the get accessor must return the value of the field, and the set accessor must assign the value to the field
        //note that the value keyword is used to define the value being assigned by the set accessor
        //note that the property must be public to be accessible from outside the class
        //note that the access modifier must be specified before the return type of the get accessor
        //note that the access modifier must be specified before the return type of the set accessor
        //note that the access modifier must be specified before the data type of the property
        //note that the access modifier must be specified before the name of the property
        //note that the property must be public to be accessible from outside the class
    static void Main(string[] args)
        {
        }
    }
}