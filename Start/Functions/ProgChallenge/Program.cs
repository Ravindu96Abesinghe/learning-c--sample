﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
// IsPalindrome returns a tuple of two values
(bool, int) IsPalindrome(string thestr) {
    string teststr;

    // Convert the string to upper-case
    teststr = thestr.ToUpper();

    // Use a StringBuilder to strip out all the punctuation
    var sb = new StringBuilder();
    foreach (char c in teststr) {
        //Add characters to the buider if not punctuation or white spase
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) {
            sb.Append(c);
        }
    }

    // Convert the builder to the finished string
    teststr = sb.ToString(); 

    // Convert characters starting at begining and end of string
    int i=0, j=teststr.Length-1;

    // if the indexes cross each other , then we're done
    while (i <= j) {
        // If the character at each index doesn't match, it's not a palindrome
        if (teststr[i] != teststr[j]) {
            return(false, 0);
        }
        // update the counters and tey again
        i++;
        j++;
    }
    // if qw reach this point, we must have a palindrome
    return (true, thestr.Length);
}

string inputstr="";
(bool b, int l) result;
Console.WriteLine("Let's begin:");
while (inputstr != "exit") {
    inputstr = Console.ReadLine();
    if (inputstr != "exit") {
        result = IsPalindrome(inputstr);
        Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
    }
}

