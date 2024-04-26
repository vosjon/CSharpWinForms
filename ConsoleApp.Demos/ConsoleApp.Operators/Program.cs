// Section 6 - Arithmetic, Logical and Assignment Operators

int num1 = 0, num2 = 0;

Console.Write("Please enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;
int product = num1 * num2;
int quotient = num1 / num2;
int difference = num1 - num2;
int mod = num1 % num2;

Console.WriteLine("\n******************* Math Results *******************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("***************** End Math Results *****************");

// Logic Operations and Operators

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("\n******************* Logic Results ******************");
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine("***************** End Logic Results ****************");

// Assignment Operations and Operators

Console.WriteLine("\n*************** Assignment Results *****************");
num1 += 5;
Console.WriteLine($"Num1 increased by 5: {num1}");
num1 -= 3;
Console.WriteLine($"Num1 reduced by 3: {num1}");
num1 /= 2;
Console.WriteLine($"Num1 divided by 2: {num1}");
num1 %= 2;
Console.WriteLine($"Num1 mod by 2: {num1}");
num1 *= 10;
Console.WriteLine($"Num1 multiplied by 10: {num1}");
Console.WriteLine("************** End Assignment Results ***************");