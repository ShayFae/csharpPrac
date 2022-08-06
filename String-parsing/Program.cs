using System.Globalization;

string numStr = "1";
string numStr1 = "2.00";
string numStr2 = "3,000";
string numStr3 = "3,000.00";

int targetNum = 0;
try {
  targetNum = int.Parse(numStr);
  Console.WriteLine(targetNum);

  targetNum = int.Parse(numStr1, NumberStyles.Float);
  Console.WriteLine(targetNum);

  targetNum = int.Parse(numStr2, NumberStyles.AllowThousands);
  Console.WriteLine(targetNum);

  targetNum = int.Parse(numStr3, NumberStyles.Float | NumberStyles.AllowThousands);
  Console.WriteLine(targetNum);

  Console.WriteLine($"{bool.Parse("True")}");
  Console.WriteLine($"{float.Parse("1.235"):F2}");
} catch {
  Console.WriteLine("Conversion failed");
}

bool succeeded = false;
succeeded = Int32.TryParse(numStr, out targetNum);
if(succeeded) {
  Console.WriteLine($"{targetNum}");
}