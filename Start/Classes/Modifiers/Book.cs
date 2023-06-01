// See https://aka.ms/new-console-template for more information

public class Book
{
    // classes have instance variables to hold data
    private string _name;
    private string _author;
    private int _pagecount;

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

    // Member variables can be accessed via methods
    public string GetName() {
        return _name;
    }
    public void SetName(string s) {
        _name = s;
    }
    public void SetAuthor(string s) {
        _author = s;
    }
    public void SetPagecount(int c) {
        _pagecount = c;
    }
}
