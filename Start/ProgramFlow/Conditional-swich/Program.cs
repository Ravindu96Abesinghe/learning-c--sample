﻿// See https://aka.ms/new-console-template for more information

int theVal = 60;

// TODO: The swich statement
switch (theVal) {
    case 50:
        Console.WriteLine("theVal is 50");
        break;
    case 51:
        Console.WriteLine("theVal is 51");
        break;
    case 52:
    case 53:
    case 54:
        Console.WriteLine("theVal is between 52 and 54");
        break;
    default:
        Console.WriteLine("theVal is something else");
        break;
}
