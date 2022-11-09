using System;

Console.WriteLine("Library Managemenet System");
Console.WriteLine("Options: \nc for C# books \no for .Net core books  \nd for clean coding books \ne for EFCore books");

string userChoice = Convert.ToString(Console.ReadLine().ToLower());

if(userChoice == "c")
{
    Console.WriteLine("C# books available");
}
else if(userChoice == "o")
{
    Console.WriteLine(".Net core books available");
}
else if(userChoice == "d")
{
    Console.WriteLine("Clean coding books available");
}
else if(userChoice == "e")
{
    Console.WriteLine("EFCore books available");
}
else
{
    Console.WriteLine("Wrong input, try again");
}

Console.Read();