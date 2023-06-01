// See https://aka.ms/new-console-template for more information

public class Book
{
    // classes have member variables, or "Fields" to hold data
    public string _name;

    protected string _author;

    private int _pagecount;

    // classes have one or more constructors
    public Book (string name, string author, int pages) {
        _name = name;
        _author  = author;
        _pagecount = pages;
    }
    
    // use Properties to implement access to our internal data
    // This is called a Property with a "backing field"
    public string Name {
        get {
            return _name;
        }
        set {
            _name = value;
        }
    }

    // There's a shorthand way of writing these using the => operator
    // to create "expression-bodied" properties
    public string Author {
        get => _author;
        set => _author = value;
    }
    public int Pagecount {
        get => _pagecount;
        set => _pagecount = value;
    }


    // You can omit the get or set if you want to prevent
    // modification or reading the value, or if youn want to create
    // a "Computed Property" from other fields
    public string Description {
        get => $"{Name} by {Author}, {Pagecount} pages";
    }

    // Properties can be auto-generated - if there's no
    // backing field, the property can hold the data
    public string ISBN {
        get; set;
    }
    public decimal Price {
        get; set;
    }
}
