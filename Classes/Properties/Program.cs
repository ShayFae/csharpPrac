namespace Properties 
{
  class Program 
  {
    static void Main(string[] args) 
    {

      Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
      Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

      Console.WriteLine(b1.Name);
      Console.WriteLine(b1.Description);

      //Set ISBN and Price properties
      b1.ISBN = "281930192931";
      b1.Price = 30.55m;
      Console.WriteLine(b1.ISBN);
      Console.WriteLine(b1.Price);

      //Change Name and Pagecount
      b1.Name = "This is a new title";
      b1.Pagecount = 500;
      Console.WriteLine(b1.Description);
      Console.WriteLine(b1.Name);
      Console.WriteLine(b1.Pagecount);

    }
  }
}