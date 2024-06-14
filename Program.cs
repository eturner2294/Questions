// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Pleasse enter a string of letters for Q1");

Questions questions = new Questions();
String input = Console.ReadLine();
Console.WriteLine(questions.getWrongAnswers(input.Length, input));

Console.WriteLine("Please enter 3 characters for Q2");
input = Console.ReadLine();

Char[] stringToChar = input.ToCharArray();
Console.WriteLine(questions.GetSum(stringToChar[0], stringToChar[1], stringToChar[3]));  


