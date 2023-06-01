 // See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Create new object instances using the "new" operator
        Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);


        // In previous example, this would fail, but will now
        // work since the field name is declared as public
        // b1._name = "Cat in the Hat";
        // Console.WriteLine(b1.GetDescription());

        // Set data using functions instead of accessing field directly
        b1.SetName("Grapes of Wrath");
        b1.SetAuthor("John Steinbeck");
        b1.SetPagecount(464);
        Console.WriteLine(b1.GetDescription()); 
    }
}
