// Section 7 Conditional Statements

// Prompt for input
Console.Write("Please enter a student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pass or fail based on input
if (grade > 50) 
{
    Console.WriteLine("Pass");
}
else
{
    Console.WriteLine("Fail");
}