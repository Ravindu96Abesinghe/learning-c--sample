﻿// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        // Create new object instances using the "new" operator
        Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
        Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);


        // Call a method on the object
        Console.WriteLine(b1.GetDescription());
        Console.WriteLine(b2.GetDescription());

        // Try to set one of the properties --
        // this will result in an error
    }
}
