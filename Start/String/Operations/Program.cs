// See https://aka.ms/new-console-template for more information

// Declare some strings for the exercises
string outstr;
string str1 = "The quick brown fox jump over the lazy dog.";
string str2 = "This is a string";
string str3 = "This is a STRING";
string[] strs = {"one", "two", "three", "four"};

//TODO: Length of a string
Console.WriteLine(str1.Length);

//TODO: Access individual characters
Console.WriteLine(str1[14]);

//TODO: iterate over a string like any other sequence of value
foreach (char ch in str1) {
    Console.Write(ch);
    if (ch == 'b') {
        Console.WriteLine();
        break;
    }
}

//TODO: String Concatenation
outstr = String.Concat(strs);
Console.WriteLine(outstr);

//TODO: Joining strings together with JOIN
outstr = String.Join('.', strs);
Console.WriteLine(outstr);

outstr = String.Join("----", strs);
Console.WriteLine(outstr);

//TODO: String Comparison
int result =  String.Compare(str2, "This is a string");
Console.WriteLine(result);

//TODO: Equals just returns a reguler Boolean
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

//TODO: String Searching
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("the"));

outstr = str1.Replace("fox", "cat");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf("fox"));