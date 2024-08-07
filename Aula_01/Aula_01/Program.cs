// See https://aka.ms/new-console-template for more information
String nome;
String sobrenome;
int idade;

Console.Write("escreva seu nome: ");
nome = Console.ReadLine();

Console.Write("escreva seu sobrenome: ");
sobrenome = Console.ReadLine();

Console.Write("escreva sua idade: ");
idade = int.Parse(Console.ReadLine());




Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("seu nome é: " + nome + " " + sobrenome + " e sua idade é: " + idade.ToString());