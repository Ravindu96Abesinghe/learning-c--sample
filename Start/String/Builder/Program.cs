﻿ // See https://aka.ms/new-console-template for more information

int jumpCount = 10;
string[] animals = {"goats", "cats", "pigs"};

// TODO: create a StringBuilder
StringBuilder sb = new StringBuilder("Initial string.", 200);

// TODO: print some basic stats about the StringBuilder
Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

// TODO: Add some string to the builder using Append
sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog.");

// TODO: AppendLine can append a line ending
sb.AppendLine();

// TODO: AppenFormat can be used to append formatted strings
sb.AppenFormat("He did this {0} times.", jumpCount);
sb.AppendLine();

// TODO: AppendJoin can iterate over a set of values
sb.Append("He also jumped over");
sb.AppendJoin(',', animals);

// TODO: Modify the content using Replace
sb.Replace("fox", "cat");

// TODO: Insert content at any index
sb.Insert(0, "This is the ");

// TODO: Convert to a single string
Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
Console.WriteLine(sb.ToString());