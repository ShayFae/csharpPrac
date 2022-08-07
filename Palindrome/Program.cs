namespace Palindromes {
  class Program {
    // Console.WriteLine("Let's begin:");
    int lens = 0;
    bool y = false;
    string j = "True";
    string m = "False";
    static void Main(string[] args) {
      string userStr = Console.ReadLine();
      Console.WriteLine(userStr.Reverse());
      var reverseText = string.Join("", userStr.ToLower().Reverse());
       if (reverseText == userStr) {
        !y;
        n = j;
       }

      (bool, int) result = Palindrome(n, userStr);
      
      // if (myArr = userStr) {
      //   Console.WriteLine("Yes");
      // }
      Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
    }
    static (bool, int) Palindrome(string check, string len) {
      //  var reverseText = string.Join("", find.ToLower().Reverse());
      //  if (reverseText == find) {
      //   Console.WriteLine("Yes");
      //  }
        // return reverseText == find;
     
      // string guess = Console.ReadLine();
      // test = guess.Replace(" ", "");
      // Console.WriteLine(test);
      return(check, len.Length);
    }
  }
}