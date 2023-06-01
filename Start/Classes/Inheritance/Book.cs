// See https://aka.ms/new-console-template for more information

class Book : Publication
{
    // classes have instance variables to hold data
    private string _author;

    // use the base() keyword to initialize the base class
    public Book (string name, string author, int pagecount, decimal price) 
        : base(name, pagecount, price) {
        _author  = author;
    }

    public string Author {
        get => _author;
        set => _author = value;
    }

    // public int PageCount {
    //     get => _pagecount;
    //     set => _pagecount = value;
    // }


    // use the override keyword to override a base class method
    public override string GetDescription() {
        return $"{Name} by {Author}, {PageCount} pages";
    }
}
