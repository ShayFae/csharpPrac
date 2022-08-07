float MilesToKm(float miles) {
  float result = miles * 1.6f;
  return result;
}

Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

void PrintWithPrefix(string theStr) {
  Console.WriteLine($"::> {theStr}");
}

PrintWithPrefix("Test String");
PrintWithPrefix("I like trains");