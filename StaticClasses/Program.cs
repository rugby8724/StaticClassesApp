
using StaticClasses;

SampleMethods.SayHello();

string firstName = RequestData.GetAString("What is your first name: ");

UserMessages.ApplicationStatMessage(firstName);


double x = RequestData.GetADouble("Please enter your first number: ");

double y = RequestData.GetADouble("Please enter your second number: ");

double result = CalculateData.Add(x, y);

UserMessages.PrintResults($"The sum of {x} and {y} is {result}");




Console.ReadLine();