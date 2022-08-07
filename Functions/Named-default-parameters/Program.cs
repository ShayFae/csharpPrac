//Prefix parameter was given an empty string as a default
void PrintWithPrefix(string thestr, string prefix="") {
  Console.WriteLine($"{prefix}{thestr}");
}

PrintWithPrefix("Hello There");
PrintWithPrefix("Hello There", ">: ");

//Can be out of order when you name the params
PrintWithPrefix(prefix: "% ", thestr: "Hello there");