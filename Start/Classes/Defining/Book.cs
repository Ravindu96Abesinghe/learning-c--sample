// See https://aka.ms/new-console-template for more information

public class Book
{
    // classes have member variables, or "Fields" to hold data
    string _name;
    string _author;
    int _pagecount;

    // classes have one or more constructors
    public Book (string name, string author, int pages) {
        _name = name;
        _author  = author;
        _pagecount = pages;
    }

    // method are used to operate on the class and date
    public string GetDescription() {
        return $"{_name} by {_author}, {_pagecount} pages";
    }
}
