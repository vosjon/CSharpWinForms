// Video 16-17: Variables Part 1 and 2

string name = "Jonathan Vos";

Console.WriteLine("I am " + name + "."); // Concatenation
Console.WriteLine($"They call me {name}."); // String interpolation
Console.WriteLine("I was given the name {0}.", name); // Formatted string

int age = 36;
int retirementYearsLeft = 14;
int retirementAge = age + retirementYearsLeft;
Console.WriteLine("\nMy age is: " + age);
Console.WriteLine("My retirement age is: {0}", retirementAge);

bool isRetired = false;
Console.WriteLine("\nAm I retired? " + isRetired);