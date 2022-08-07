namespace RefAndOutParams {
  class Program {
    static void TestFunc1(int arg1) {
      arg1 += 10;
      Console.WriteLine($"{arg1}");
    }

    static void TestFunc2(ref int arg1) {
      arg1 += 10;
      Console.WriteLine($"{arg1}");
    }

    static void PlusTimes(int arg1, int arg2, out int sum, out int product) {
      sum = arg1 + arg2;
      product = arg1 * arg2;
    }

    static void Main(string[] args) {
      int val = 10;
      int val2 = 20;

      TestFunc1(val);
      Console.WriteLine($"{val}");
      TestFunc2(ref val);
      Console.WriteLine($"{val}");

      int a, b;
      PlusTimes(val, val2, out a, out b);
      Console.WriteLine($"{a}, {b}");
    }

  }
}