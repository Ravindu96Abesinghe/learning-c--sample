// See https://aka.ms/new-console-template for more information

class Book
{
    // classes have member variables, or "Fields" to hold data
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageCount { get; }

    // classes have one or more constructors
    public Book (string name, string author, int pages) {
        Name = name;
        Author  = author;
        PageCount = pages;
    }

    // The To String method generates a string represenation of the object
    public override string ToString() {
        return $"Book: {Name} by {Author}";
    }

    // ToString can be overloaded to give different format vertions
    // Notice that this version is NOT an override function
    public string ToString(char format) {
        if (format == 'B') {
            return $"Book: {Name}:{Author}";
        }
        if (format == 'F') {
            return $"Book: {Name} by {Author} is {PageCount} pages";
        }
        return ToString();
    }
    
}
