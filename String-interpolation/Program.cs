string make = "Mercedes-Benz";
string model = "G Class";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}", year, make, model, miles, price);

//$: Interpolation
Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs {price:C2}", year, make, model, miles, price);

//Can also use double brace to escape and allow the brace to be shown in the string
Console.WriteLine($"This car is a {year} {make} {model}, with {{{miles * 1.6:F2}}} km and costs {price:C2}", year, make, model, miles, price);


