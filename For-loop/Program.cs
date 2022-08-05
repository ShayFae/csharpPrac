int val = 11;

Console.WriteLine("Commander on your orders we will take off. Please state yes if we're ready");
string response = Console.ReadLine();

if(response == "yes") {
  for(int i = 1; i < val; i++) {
  Console.WriteLine("Lift off in {0}", i);
  }
} else {
  Console.WriteLine("On standby");
}

int[] numArr = new int[] {1, 34, 27, 111, 2, 68, 212,3};

foreach(int x in numArr) {
  Console.WriteLine("{0}", x);
}

string str = "Happy Birthday To You";

var count = 0;
foreach(char s in str) {
  // if (s == "o") {
  //   count++;
  // }
  Console.WriteLine("{0}", s);
}
  Console.WriteLine("Counted {0} o characters in that string", count);
