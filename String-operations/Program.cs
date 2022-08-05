string outstr;

string str = "This is a string";
string str1 = "THIS IS A STRING";
string str2 = "This is a much longer string";

string[] strArr = {"one", "two", "three", "four", "five"};

Console.WriteLine(str.Length);

Console.WriteLine(str[14]);

foreach(char s in str) {
  Console.Write(s);
  if (s == 's') {
    Console.WriteLine();
    break;
  }
}

outstr = String.Concat(strArr);
Console.WriteLine(outstr);

outstr = String.Join(".", strArr);
Console.WriteLine(outstr);

outstr = String.Join("---", strArr);
Console.WriteLine(outstr);

int result = String.Compare(str1, "This is a string");
Console.WriteLine(result);

bool isEqual = str1.Equals(str2);

Console.WriteLine(isEqual);

Console.WriteLine(str.IndexOf('s'));
Console.WriteLine(str.IndexOf("is"));
Console.WriteLine(str.LastIndexOf("string"));
Console.WriteLine(str.LastIndexOf("a"));

outstr = str.Replace("a", "not");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf('a'));