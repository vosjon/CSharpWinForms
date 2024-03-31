// Video 19 - Coding Exercise - User Input Demo

string? name = string.Empty;
int age = 0;
int retirementAge = 50;

Console.Write("Please enter your full name: ");
name = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

int workingYearsRemaining = retirementAge - age;

Console.WriteLine("\nThank you for the information. Here is what I know about you:");
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");