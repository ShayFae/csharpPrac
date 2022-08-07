namespace Inheritance 
{
  class Book : Publication { 
    private string _author;

    public Book(string name, string author, int pagecount, decimal price) : base(name, pagecount, price){
      // _name = name;
      _author = author;
      // _pagecount = pages;
      
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

    public override string GetDescription() {
      return $"{Name} bt {PageCount} pages";
    }


    // public int Pagecount {
    //   get => _pagecount; //Read
    //   set => _pagecount = value; //Write
    // }

    // public string Description {
    //   get => $"{Name} by {Author}, {Pagecount} pages";
    // }

    // //No internal data field just holds data directly(No backing field)
    // public string ISBN {
    //   get; set; //Auto generate getter/setter
    // }

    // public decimal Price {
    //   get; set;//Auto generate getter/setter

    // }
    
  }
}