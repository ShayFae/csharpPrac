namespace Palindromes {
  class Program {
    // Console.WriteLine("Let's begin:");
 
    static void Main(string[] args) {
    bool find;
    string userStr = Console.ReadLine().Replace(" ", "");

    var reverseText = string.Join("", userStr.ToLower().Reverse());
    var removeSpace = reverseText.Replace(" ", "");
    Console.WriteLine(removeSpace);
      if (removeSpace == userStr) {
        find = true;
       } else {
        find = false;
       }

    (bool, int) result = Palindrome(find, userStr);
    Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
    }
    static (bool, int) Palindrome(bool check, string len) {
      return(check, len.Length);
    }
  }
}