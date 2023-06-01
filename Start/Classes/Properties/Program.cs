// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Create new object instances using the "new" operator
        Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

        // Access a couple of properties
        Console.WriteLine(b1.Name);
        Console.WriteLine(b1.Description);

        // Set the ISBN and Price properties
        b1.ISBN = "100140447938";
        b1.Price = 24.95m;
        Console.WriteLine(b1.ISBN);
        Console.WriteLine(b1.Price);

        // Change the Name and Pagecount
        b1.Name = "Crome and Punishment";
        b1.Pagecount = 652;
        Console.WriteLine(b1.Description);
        Console.WriteLine(b1.Name);
        Console.WriteLine(b1.Pagecount);

    }
}
