int theVal = 55;

//If-else
if(theVal == 50) {
  Console.WriteLine("theVal is 50");
} else if(theVal >= 51 && theVal <= 60) {
    Console.WriteLine("theVal is between 51 and 60");
  } else {
  Console.WriteLine("theVal equals something else");
}

//Ternary Operator
Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");