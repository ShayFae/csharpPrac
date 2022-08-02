// See https://aka.ms/new-console-template for more information
int x = 10, y = 5;
string a = "abcd";
string b = "efgh";

Console.WriteLine("Math");
Console.WriteLine((x / y) * x);
Console.WriteLine(a + b);

x++; //x now = 11
y--; //y now  = 4

Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);

string nothing = null;
Console.WriteLine(nothing ?? "Unknown String");

nothing ??= "New string";
Console.WriteLine(nothing);