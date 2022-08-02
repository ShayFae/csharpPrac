// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//When decalring a variable you must specify the type 
string name = "Ifrah"; //The variable type is a string declared at the start along with name and then the value assigned to it

//Examples
int age = 25;
decimal pie = 3.14m;
float zero = 5.0f;
bool boolean = false;
// char character = "c";

//You could use Var
var num = 5;
var greeting = "Hello";

//Creating an Array
int[] arr = new int[10];
string[] strArr = {"Hello", "World"};

Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", name, age, pie, zero, boolean, num, greeting);

//Types that are the same can be converted like this
long bignum;
bignum = age;

//If not then you convert it like this
float int_to_float = (float)age;
int float_to_int = (int)zero;
Console.WriteLine("{0},{1}", int_to_float, float_to_int);