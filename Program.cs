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
/*
History of c-sharp
Developed by Microsoft
first version was released in year 2002. The latest version, C# 13, was released in November 2024.
Part of .NET Framework
Designed to be a modern object oriented programming language that could compete with java
*/
/*
Fearures and capabilities
Object oriented
Type safety
Productivity tools
C-# in enterprise software development
Backend services
Business applications
Data visualisation
Rapid prototyping

C-# in game development
Unity
Unreal engine
Monogame
Gad engine
C-#in web development\
ASP.NET
Blazor
signalR
Web API
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
//value types and reference types in C#
//Value types: store the actual data directly in memory. Examples include int, double, char
//Reference types: store a reference to the data in memory. Examples include string, arrays, classes
//Value type example
int valueA = 10; // valueA holds the actual value 10
int valueB = valueA; // valueB is assigned the value of valueA (10)
valueB = 20; // changing valueB does not affect valueA
Console.WriteLine("Value A: " + valueA); // 10
Console.WriteLine("Value B: " + valueB); // 20
//Reference type example
string referenceA = "Hello"; // referenceA holds a reference to the string "Hello"
string referenceB = referenceA; // referenceB is assigned the reference of referenceA (points to the same string "Hello")
referenceB = "World"; // changing referenceB does not affect referenceA
Console.WriteLine("Reference A: " + referenceA); //  Hello
Console.WriteLine("Reference B: " + referenceB); //  World

Console.WriteLine($"{referenceA} {referenceB},welcome"); //  Hello World
Console.ReadKey(); 
//warning and error in c#
//Warning: A warning is a message that indicates a potential issue in the code that may not prevent the program from running but could lead to unexpected behavior or bugs. 
//error: An error is a message that indicates a problem in the code that prevents the program from compiling or running. 

//type casting in c#
//Implicit Casting (automatically) - converting a smaller type to a larger type size
//char -> int -> long -> float -> double
//example of implicit casting
int num_1 = 10; // int is a smaller type
double num_2 = num_1; // implicit casting from int to double
Console.WriteLine("Implicit Casting: " + num_2); // Output: 10.0
//Explicit Casting (manually) - converting a larger type to a smaller size type
//double -> float -> long -> int -> char
//example of explicit casting
double num_3 = 3.14; // double is a larger type
int num_4 = (int)num_3; // explicit casting from double to int
Console.WriteLine("Explicit Casting: " + num_4); // Output: 3 (the decimal part is truncated)
//what if we try to cast a larger type to a smaller type without explicit casting?
//double num_5 = 3.14; // double is a larger type
//int num_6 = num_5; // This will cause a compile-time error because it is trying to assign a double value to an int variable without explicit casting
//Console.WriteLine("Without Explicit Casting: " + num_6); // This line will not compile due to the error in the previous line
//Type Conversion Methods
//C# provides built-in methods for converting between different data types. Some common type conversion methods include:
//Convert.ToInt32() - converts a value to an integer
//Convert.ToDouble() - converts a value to a double
//Convert.ToString() - converts a value to a string
//Convert.ToBoolean() - converts a value to a boolean
//Example of type conversion methods
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

Console.ReadKey();

//using parsing methods to convert strings to other data types
//C# provides parsing methods to convert strings to other data types. Some common parsing methods include:
//int.Parse() - converts a string to an integer
//double.Parse() - converts a string to a double
//bool.Parse() - converts a string to a boolean
//Example of parsing methods
string intString = "42";
string doubleString = "3.14";
string boolString = "true";	

int parsedInt = int.Parse(intString);
double parsedDouble = double.Parse(doubleString);
bool parsedBool = bool.Parse(boolString);

Console.WriteLine("Parsed Int: " + parsedInt);
Console.WriteLine("Parsed Double: " + parsedDouble);
Console.WriteLine("Parsed Bool: " + parsedBool);

Console.ReadKey();


Console.WriteLine("Enter your age:");
int your_age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + your_age);

//parse is used to convert a string to a specific data type
//difference between parse and convert
//The main difference between parse and convert is that parse is a method that belongs to a specific data type (e.g., int.Parse(), double.Parse()), while convert is a class that provides static methods for converting between different data types (e.g., Convert.ToInt32(), Convert.ToDouble()).
//for user input, we often need to parse the input string to the desired data type
//we use type conversion - to ensure variables match the expected data type for calculations or other operations
Console.WriteLine("Enter a number:");
int mynum=0;
mynum = int.Parse(Console.ReadLine() !);

string userInput = Console.ReadLine() !;
mynum = int.Parse(userInput);

Console.WriteLine("You entered: " + mynum);
//example calculator using user input and type conversion
//airthmetic operations
//addition, subtraction, multiplication, division
string input1 = Console.ReadLine() !;
string input2 = Console.ReadLine() !;
Console.WriteLine("Enter the first number:");
int number_1 = int.Parse(input1);
Console.WriteLine("Enter the second number:");
int number_2 = int.Parse(input2);
//addition
int sum_ans = number_1 + number_2;
//subtraction
int difference_ans = number_1 - number_2;
//multiplication
int product_ans = number_1 * number_2;
//division
int quotient_ans = number_1 / number_2;	

Console.WriteLine("The sum of " + number_1 + " and " + number_2 + " is: " + sum_ans);
Console.WriteLine("The difference of " + number_1 + " and " + number_2 + " is: " + difference_ans);
Console.WriteLine("The product of " + number_1 + " and " + number_2 + " is: " + product_ans);
Console.WriteLine("The quotient of " + number_1 + " and " + number_2 + " is: " + quotient_ans);
Console.ReadKey();
//assignment operators in C#
//=, +=, -=, *=, /=, %=
int a1 = 10;
a1 += 5; // equivalent to a1 = a1 + 5;
Console.WriteLine("After += operator: " + a1); // Output: 15
int a2 = 20;
a2 -= 5; // equivalent to a2 = a2 - 5;
Console.WriteLine("After -= operator: " + a2); // Output: 15
int a3 = 5;
a3 *= 2; // equivalent to a3 = a3 * 2;
Console.WriteLine("After *= operator: " + a3); // Output: 10
int a4 = 10;
a4 /= 2; // equivalent to a4 = a4 / 2;
Console.WriteLine("After /= operator: " + a4); // Output: 5
int a5 = 10;
a5 %= 3; // equivalent to a5 = a5 % 3;
Console.WriteLine("After %= operator: " + a5); // Output: 1
Console.ReadKey();
//comparison operators in C#
//==, !=, >, <, >=, <=
int x1 = 10;
int y1 = 20;
Console.WriteLine("x1 == y1: " + (x1 == y1));
Console.WriteLine("x1 != y1: " + (x1 != y1));
Console.WriteLine("x1 > y1: " + (x1 > y1));
Console.WriteLine("x1 < y1: " + (x1 < y1));
Console.WriteLine("x1 >= y1: " + (x1 >= y1));
Console.WriteLine("x1 <= y1: " + (x1 <= y1));
Console.ReadKey();
//output:
//x1 == y1: False
//x1 != y1: True
//x1 > y1: False
//x1 < y1: True
//x1 >= y1: False
//x1 <= y1: True	
//logical operators in C#
//&&, ||, !
bool conditionA = true;
bool conditionB = false;
Console.WriteLine("conditionA && conditionB: " + (conditionA && conditionB)); // Output: False
Console.WriteLine("conditionA || conditionB: " + (conditionA || conditionB)); // Output: True
Console.WriteLine("!conditionA: " + (!conditionA)); // Output: False
Console.WriteLine("!conditionB: " + (!conditionB)); // Output: True
Console.ReadKey();
//math
//Math.Abs() - returns the absolute value of a number
//Math.Pow() - returns a number raised to the power of another number
//Math.Sqrt() - returns the square root of a number
//Math.Round() - rounds a number to the nearest integer or specified number of decimal places
//Math.Min() - returns the smaller of two numbers
//Math.Max() - returns the larger of two numbers
//examples of math methods
double numA = -5.5;
double numB = 2.0;
Console.WriteLine("Absolute value of numA: " + Math.Abs(numA)); 
Console.WriteLine("numA raised to the power of numB: " + Math.Pow(numA, numB)); 
Console.WriteLine("Square root of numB: " + Math.Sqrt(numB)); 
Console.WriteLine("Rounded value of numA: " + Math.Round(numA));
Console.WriteLine("Minimum of numA and numB: " + Math.Min(numA, numB)); 
Console.WriteLine("Maximum of numA and numB: " + Math.Max(numA, numB)); 
Console.ReadKey();
//string methods in C#
//String.Length - returns the number of characters in a string
//String.ToUpper() - converts a string to uppercase
//String.ToLower() - converts a string to lowercase
//String.Contains() - checks if a string contains a specified substring
//String.Replace() - replaces occurrences of a specified substring with another substring
//String.Substring() - returns a substring from a string based on specified starting index and length
//examples of string methods
string str = "Hello, World!";
Console.WriteLine("Length of str: " + str.Length);	
Console.WriteLine("Uppercase str: " + str.ToUpper());
Console.WriteLine("Lowercase str: " + str.ToLower());
Console.WriteLine("Does str contain 'World'? " + str.Contains("World"));
Console.WriteLine("Replace 'World' with 'C#': " + str.Replace("World", "C#"));
Console.WriteLine("Substring of str (starting at index 7, length 5): " + str.Substring(7, 5));
Console.ReadKey();

//concatenation of strings
string fName = "pavani";
string lName = "reddy";
string full_Name = string.Concat("VM ",fName, " ", lName); 
Console.WriteLine("Full Name: " + full_Name); 
Console.ReadKey();
//interpolation of strings
string fullNameInterpolated = $"VM {fName} {lName}";
Console.WriteLine("Full Name (Interpolated): " + fullNameInterpolated);
Console.ReadKey();

//access string characters using indexing
string sampleString = "Hello, World!";
char firstChar = sampleString[0];
Console.WriteLine("First character: " + firstChar); 
Console.WriteLine("Second character: " + sampleString[1]);
Console.ReadKey();
//methods
//IndexOf() - returns the index position of a specific character in a string, by using the IndexOf() method:
//Substring() - returns a substring from a string based on specified starting index and length
int index = sampleString.IndexOf('W');
Console.WriteLine("Index of 'W': " + index);
Console.ReadKey();
//special characters in strings
//Escape sequences are used to represent special characters in strings. Some common escape sequences include:
//\n - new line
//\t - tab
//\\ - backslash
//\" - double quote
//\' - single quote
string specialString = "Hello,\nWorld!\tThis is a string with special characters:\n- New Line\n- Tab\n- Backslash: \\\n- Double Quote: \"\n- Single Quote: \'";
Console.WriteLine(specialString);
Console.ReadKey();
//booleans
bool studying = true;
bool gaming = false;
Console.WriteLine("Is studying? " + studying);
Console.WriteLine("Is gaming? " + gaming);
Console.ReadKey();
int myAge = 21;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);
