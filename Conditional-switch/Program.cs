int newVal = 50;

switch(newVal) {
  case 50:
    Console.WriteLine("This value equals 50");
    break;
  case 51:
    Console.WriteLine("This value equals 51");
    break;
  case 52:
  case 53:
  case 54:
    Console.WriteLine("This value is between 52 to 54");
    break;
  default:
    Console.WriteLine("The value equals something else");
    break;
}