// See https://aka.ms/new-console-template for more information

// Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix="")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// Test the default parameters
PrintWithPrefix("Hello There!");
PrintWithPrefix("Hello There!", ">: ");

// call with named parameters
PrintWithPrefix(prefix: "% ", thestr: "Hello There!");
