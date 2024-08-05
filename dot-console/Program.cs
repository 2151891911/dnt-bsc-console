// See https://aka.ms/new-console-template for more information

using System.Collections;

int convertValue = 5;
float myFloat = 6.0f;

decimal myDecimal = 5.9m;

Console.WriteLine(typeof(int)); // Value type
Console.WriteLine(typeof(TextWriter)); // Class type
Console.WriteLine(typeof(Array)); // Class type
Console.WriteLine(typeof(int[])); // Array reference type

float myDouble = Convert.ToInt32(convertValue);

Console.WriteLine(myDouble);
Console.WriteLine(myFloat);


float decimalQuotient = 1.0f * 7 / 5;

Console.WriteLine(decimalQuotient);

int overflowTheInteger = int.MaxValue;

overflowTheInteger ++;

Console.WriteLine(overflowTheInteger);

int? aTest = null;

Console.WriteLine(aTest);
Console.WriteLine(">>> executed");

    