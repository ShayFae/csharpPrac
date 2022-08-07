namespace Properties 
{
  public class Book 
  {
    private string _name;
    private string _author;
    private int _pagecount;

    public Book(string name, string author, int pages) {
      _name = name;
      _author = author;
      _pagecount = pages;
    }
    
    //Backing field property
    public string Name {
      get {
        return _name;
      }
      set {
        _name = value;
      }
    }

    //Shorthand of backing field properties 
    //It is expression-bodied properties
    public string Author {
      get => _author; //Read
      set => _author = value; //Write
    }

    public int Pagecount {
      get => _pagecount; //Read
      set => _pagecount = value; //Write
    }

    public string Description {
      get => $"{Name} by {Author}, {Pagecount} pages";
    }

    //No internal data field just holds data directly(No backing field)
    public string ISBN {
      get; set; //Auto generate getter/setter
    }

    public decimal Price {
      get; set;//Auto generate getter/setter

    }
    
  }
}