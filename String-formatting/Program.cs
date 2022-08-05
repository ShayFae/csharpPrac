int[] quarters = {1, 2, 3, 4, 5};
int[] sales = {1000, 2000, 3000, 40000};
double[] intMixPct = {.212, .567, .734, .129};
string str = "TestStr";
int val = 12345;
decimal val1 = 12345.67891m; 

//D: Decimal, N: Number, F: Fixed point, G: General, E: Exponential
Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val);
Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val1);

//You can specify the amount you want 
Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val);

Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quarters[0], quarters[1], quarters[2], quarters[3]);
Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);
Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}", intMixPct[0], intMixPct[1], intMixPct[2], intMixPct[3]);

