/*
C#
syntax
using System;   //refernce of .Net Framework Namespaces
namespace helloworld{  //Namespace name
	class program{    //class name
		static void main(String[]args){. ////method
			Console.WriteLine(“hello world”);    //method to display value on console
		}
	}
}
*/
Console.WriteLine("Hello, World!");
Console.WriteLine(3 + 7);
Console.ReadKey();
//Single-line Comments
/*C# Multi-line
 Comments
*/
//<summary>
//summary of the program
//</summary>
//Declaring (Creating) Variables
//type variableName = value;//Data Types in C#//string, int, double, char, bool
string name = "pavani";
Console.WriteLine(name);
//You can also declare a variable without assigning the value, and assign the value later:
int myNum;
myNum = 15;
Console.WriteLine(myNum + 5);
//if you assign a new value to an existing variable, it will overwrite the previous value:
int Num = 15;
Num = 20; 
Console.WriteLine(Num);
//constants-unchangeable and read-only-don't want others (or yourself) to overwrite existing values
const double Pi = 3.14;
//Pi = 3.14159; //This will cause an error because Pi is a constant and cannot be changed
Console.WriteLine(Pi);
//Display Variables//WriteLine() method is often used to display variable values to the console window.
//combine both text and a variable, use the + character
string firstName = "vm pavani";
string lastName = "reddy";
string fullName = firstName + lastName;
Console.WriteLine("Full Name: " + fullName);
//numeric values, the + character works as a mathematical operator
int a = 5;
int b = 6;
Console.WriteLine(a + b); // Print the value of a + b
//Multiple Variables
int x, y, z;
x = y = z = 50;
//int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);
//C# Identifiers-unique names are called identifiers.
/*Rules for naming variables:
1. Variable names must begin with a letter or an underscore (_).
2. Variable names can only contain letters, digits, and underscores.
3. Variable names cannot contain spaces.
4. Variable names cannot be the same as C# keywords (e.g., int, string, if, else, etc.).
5. Variable names are case-sensitive (e.g., myVariable and myvariable are different variables).

C# Data Types
1. string: Used to store text (e.g., "Hello, World!").
2. int: Used to store whole numbers (e.g., 42).
3. double: Used to store decimal numbers (e.g., 3.14).
4. char: Used to store a single character (e.g., 'A').
5. bool: Used to store boolean values (true or false).
7. long: Used to store large whole numbers (e.g., 1234567890L).
8. float: Used to store single-precision floating-point numbers (e.g., 3.14f).
9. byte: Used to store small whole numbers (0 to 255) (e.g., 255).
*/
//C# Type Casting-Type casting is when you assign a value of one data type to another type.
/*Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double
Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
*/
//user input
//Console.ReadLine() method is used to get user input from the console window. It reads a line of text and returns it as a string.
Console.WriteLine("Enter your name:");
//variable to store user input
string userName = Console.ReadLine() !; //The ! operator is used to indicate that the value returned by Console.ReadLine() will not be null. This is a way to tell the compiler that you are sure that the user will enter a value and that it will not be null, which can help prevent potential null reference exceptions in your code.
Console.WriteLine("Hello, " + userName);
Console.ReadKey();
//readkey() method is used to wait for the user to press a key before closing the console window. It is often used at the end of a program to keep the console window open until the user is ready to close it.

//naming conventions
/*1. Camel Case: The first letter of the variable name is lowercase, and the first letter of each subsequent word is capitalized (e.g., myVariableName).
2. Pascal Case: The first letter of each word in the variable name is capitalized (e.g., MyVariableName).
3. Snake Case: Words are separated by underscores, and all letters are lowercase (e.g., my_variable_name).
4. Kebab Case: Words are separated by hyphens, and all letters are lowercase (e.g., my-variable-name).
*/
//naming conventions for classes and methods and variables
/*1. Classes: Pascal Case (e.g., MyClass, Customer, Product).
2. Methods: Pascal Case (e.g., CalculateTotal, GetUserName).
3. Variables: Camel Case (e.g., myVariable, userName).
4. Constants: All uppercase letters with underscores separating words (e.g., MAX_VALUE, PI).
*/
//example of console and their types of syntax
//Console.WriteLine() - used to display output to the console window. It can take multiple arguments and concatenate them together using the + operator. It also automatically adds a new line after the output.
Console.WriteLine("Hello, User!"); 
Console.WriteLine("The sum of 5 and 10 is: " + (5 + 10));
//Console.ReadLine() - used to read user input from the console window. It waits for the user to enter a line of text and returns it as a string.
Console.WriteLine("Enter your name:");
string UserName = Console.ReadLine() !; // Reads user input and stores it in the variable 'UserName'
Console.WriteLine("Hello, " + UserName); 
//Console.ReadKey() - used to wait for the user to press a key before closing the console window. It is often used at the end of a program to keep the console window open  until the user is ready to close it.
Console.WriteLine("Press any key to exit...");
Console.ReadKey(); // Waits for the user to press a key before closing the console window
//types of comments in C#
//Single-line comment: Used for brief explanations or notes on a single line of code.
// This is a single-line comment
/*Multi-line comment: Used for longer explanations or comments that span multiple lines.
This is a multi-line comment. It can span multiple lines and is enclosed between /* and *\/ (without the backslash).
*/
//XML documentation comment: Used to provide structured documentation for classes, methods, properties, etc. It is enclosed between /// and is often used to generate documentation for code.
/// <summary>
/// This is an XML documentation comment. It provides a summary of the program or a specific code element.
/// </summary>
//declaring variables and constants in C#
//Syntax: dataType variableName = value;
int UserAge = 25; 
string User = "pavani"; 
Console.WriteLine("User Name: " + User +", Age: " + UserAge);
//Declaring a constant: A constant is a named storage location that holds a value that cannot be changed after it is assigned.
//Syntax: const dataType constantName = value;
const double Pii = 3.14; 
//Pii=2.14159; // This will cause an error because Pii is a constant and cannot be changed
Console.WriteLine("The value of Pi is: " + Pii);
//calculations with variables
int num1 = 10;
int num2 = 5;
int sum = num1 + num2; // Addition
int difference = num1 - num2; // Subtraction
int product = num1 * num2; // Multiplication
double quotient = (double)num1 / num2; // Division (casting to double for accurate result)
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
//data types in C#
string greeting = "Hello, World!"; // string data type for text
int age = 30; // int data type for whole numbers
double pi = 3.14159; // double data type for decimal numbers
char grade = 'A'; // char data type for a single character
bool isStudent = true; // bool data type for boolean values (true or false)
long largeNumber = 1234567890L; // long data type for large whole numbers
float smallDecimal = 3.14f; // float data type for single-precision floating-point numbers
byte smallNumber = 255; // byte data type for small whole numbers (0 to 255)
Console.WriteLine("Greeting: " + greeting);
Console.WriteLine("Age: " + age);
Console.WriteLine("Pi: " + pi);
Console.WriteLine("Grade: " + grade);
Console.WriteLine("Is Student: " + isStudent);
Console.WriteLine("Large Number: " + largeNumber);
Console.WriteLine("Small Decimal: " + smallDecimal);
Console.WriteLine("Small Number: " + smallNumber);
