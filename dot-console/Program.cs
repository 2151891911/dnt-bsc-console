//---------------------------- ESI learning = primitives
// int convertValue = 5;
// float myFloat = 6.0f;

// decimal myDecimal = 5.9m;

// Console.WriteLine(typeof(int)); // Value type
// Console.WriteLine(typeof(TextWriter)); // Class type
// Console.WriteLine(typeof(Array)); // Class type
// Console.WriteLine(typeof(int[])); // Array reference type

// float myDouble = Convert.ToInt32(convertValue);

// Console.WriteLine(myDouble);
// Console.WriteLine(myFloat);

// float decimalQuotient = 1.0f * 7 / 5;

// Console.WriteLine(decimalQuotient);

// int overflowTheInteger = int.MaxValue;

// overflowTheInteger++;

// Console.WriteLine(overflowTheInteger);

// int? aTest = null;

// Console.WriteLine(aTest);
// Console.WriteLine(">>> executed");

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

//---------------------------- ESI learning program FLOW 

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Console.WriteLine("Changed Main Branch");
// Console.WriteLine("Changed something on a class again");

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration < 10 && daysUntilExpiration > 5)
// {
//     Console.WriteLine("Changed something on a class again");
// }
// else if (daysUntilExpiration < 5 && daysUntilExpiration > 0)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage} % !");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day! \n Renew now and save {discountPercentage} % !");
// }
// else Console.WriteLine("Your subscription has expired.");

// if(discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

//---------------------------- ESI learning Array-loops

// string[] fraudulentOrderIDs = new string[3];//declaration   
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// //fraudulentOrderIDs[3] = "D000";//! Index out of bounds exception//System.IndexOutOfRangeException

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";//re-assign array item based on index
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// string[] fraudulentOrderIDs1 = ["A123", "B456", "C789"]; //#Csharp12

// string[] fraudulentOrderIDs2 = { "A123", "B456", "C789" };

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");//Length

// //FOR EACH
// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)//loop
// {
//     Console.WriteLine(name);
// }

//----------------------------------EXERCISE
// string[] myOrderIDs = new string[8]// new is used only for declaration of items on an empty array
// {
//     "B123",
//     "C234",
//     "A345",
//     "C15",
//     "B177",
//     "G3003",
//     "C235",
//     "B179"
// };

// foreach (string myOrderID in myOrderIDs)
// {
//     Console.WriteLine(myOrderID);
// }

// Console.WriteLine(myOrderIDs.Length);

// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string orderID in orderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         Console.WriteLine(orderID);
//     }
// }
//-----------------------------------------EXERCISE NESTED LOOPS
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
