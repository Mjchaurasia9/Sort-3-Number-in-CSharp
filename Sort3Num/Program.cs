// See https://aka.ms/new-console-template for more information
Console.Write("Enter the Value:\t");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the Value:\t");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter the Value:\t");
int num3 = int.Parse(Console.ReadLine());

if (num1 < num2 && num1 < num3)
{
if (num2 < num3)
{
Console.WriteLine($"Sorted Number: {num1}, {num2}, {num3}");
}
else
{
Console.WriteLine($"Sorted Number: {num1}, {num3}, {num2}");
}
}

if (num2 < num1 && num2 < num3)
{
if (num1 < num3)
{
Console.WriteLine($"Sorted Number: {num2}, {num1}, {num3}");
}
else
{
Console.WriteLine($"Sorted Number: {num2}, {num3}, {num1}");
}
}

if (num3 < num2 && num3 < num1)
{
if (num2 < num1)
{
Console.WriteLine($"Sorted Number: {num3}, {num2}, {num1}");
}
else
{
Console.WriteLine($"Sorted Number: {num3}, {num1}, {num2}");
}
}
