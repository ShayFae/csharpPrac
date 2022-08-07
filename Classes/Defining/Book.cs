namespace Defining 
{
  public class Book 
  {
    public string _name;
    protected string _author;
    private int _pagecount;

    public Book(string name, string author, int pages) {
      _name = name;
      _author = author;
      _pagecount = pages;
    }

    public string GetDescription() {
      return $"{_name} by {_author}";
    }

  }
}