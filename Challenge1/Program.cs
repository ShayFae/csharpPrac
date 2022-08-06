int theNumber = new Random().Next(20);

Console.WriteLine("Let's Play 'Guess the Number'!");
Console.WriteLine("I'm thinking of a number between 0 and 20");
Console.WriteLine("Enter your guess, or -1 to give up.");

int guessParse = 0;
bool check = true;

do {
  Console.WriteLine("What's your guess?");
  string guess = Console.ReadLine();
  guessParse = int.Parse(guess);

  if(guessParse == theNumber) {
      Console.WriteLine("That's the correct answer!");
      check = false;
  }
//   else if(guessParse < theNumber) 
// {
//   Console.WriteLine("Higher");
// }
// else if(guessParse > theNumber) 
// {
//   Console.WriteLine("Lower");
// }
  else if(guessParse == -1) 
  {
    check = false;
  } else {
    Console.WriteLine("{0}", guessParse < theNumber ? "Higher" : "Lower");
  }
}
while(check);