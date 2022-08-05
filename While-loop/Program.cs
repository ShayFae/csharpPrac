string inputStr = "";

Console.WriteLine("Basic while() loop:"); 
while (inputStr != "exit") {
  inputStr = Console.ReadLine();
  Console.WriteLine("You entered: {0}", inputStr);
}  

Console.WriteLine("Basic do-while() loop:"); 
do {
  inputStr = Console.ReadLine();
  Console.WriteLine("You entered: {0}", inputStr);
} while (inputStr != "exit");