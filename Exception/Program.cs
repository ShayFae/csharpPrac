int x = 1002213123;
int y = 0;

// int v = 50;
// int z = 5;

int result;
// int result2;


try {
  if (x > 1000) {
    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
  }
  result = x / y;
  // result2 = v / z;
  Console.WriteLine("The result is: {0}", result);
  // Console.WriteLine("The result is: {0}", result2);
}
catch(DivideByZeroException e) {
  Console.WriteLine("There was an error");
  Console.WriteLine(e.Message);
}
catch(ArgumentOutOfRangeException e) {
  Console.WriteLine("Sorry 1000 is the limit");
  Console.WriteLine(e.Message);
}
finally {
  Console.WriteLine("This will always run");
}