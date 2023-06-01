// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Every class in c# inherits from object, which means
        // that every class inherits the ToString() method
        // int x = 1000;
        // Console.WriteLine(x.ToString());

        // If you don't override the method, the default behavior
        // the name of the class and the namespace
        // object a = new object();
        // Console.WriteLine(a.ToString());

        // use the ToString method on the Book class
        Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
        Console.WriteLine(b1.ToString());
        Console.WriteLine(b1);

        Console.WriteLine(b1.ToString('B'));
        Console.WriteLine(b1.ToString('F')); 

    }
}
