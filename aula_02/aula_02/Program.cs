// See https://aka.ms/new-console-template for more information
float n1;
float n2;

Console.Write("escreva n1: ");
n1 = float.Parse(Console.ReadLine());

Console.Write("escreva n2: ");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine(n1 + " + " + n2 + " = " + (n1 + n2));
Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
Console.WriteLine(n1 + " x " + n2 + " = " + (n1 * n2));
Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));