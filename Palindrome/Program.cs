namespace Palindromes {
  class Program {
    // Console.WriteLine("Let's begin:");
    string test = "";
    int lens = 0;
    string write = Console.ReadLine();
    static void Main(string[] args) {
    (bool, int) result = Palindrome(true, "asdasdasd");
      Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
    }
    static (bool, int) Palindrome(bool check, string len) {
      // string guess = Console.ReadLine();
      // test = guess.Replace(" ", "");
      // Console.WriteLine(test);
      return(check, len.Length);
    }
  }
}

