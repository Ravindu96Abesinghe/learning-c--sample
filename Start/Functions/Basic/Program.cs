﻿ // See https://aka.ms/new-console-template for more information

// Functions have a return type, name, and optional parameters
float MilesToKm(float miles) {
    float result = miles * 1.6f;
    return result; 
}

// A function with no return value has a 'void' type
void PrintWithPrefix(string theStr) {
    Console.WriteLine($"::> {theStr}");
}

// Call first function
Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

// Call second function
PrintWithPrefix("Test String");
PrintWithPrefix("Another Test String");
