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
// using System;

// // initialize variables - graded assignments
// int examAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
// int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
// int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
// int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
// int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//         studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         studentScores = loganScores;

//     else if (currentStudent == "Becky")
//         studentScores = beckyScores;
//     else if (currentStudent == "Chris")
//         studentScores = chrisScores;
//     else if (currentStudent == "Eric")
//         studentScores = ericScores;
//     else if (currentStudent == "Gregor")
//         studentScores = gregorScores;
//     else
//         continue;

//     int sumAssignmentScores = 0;// initialize/reset the sum of scored assignments


//     decimal currentStudentGrade = 0;// initialize/reset the calculated average of exam + extra credit scores


//     int gradedAssignments = 0;// initialize/reset a counter for the number of assignment 


//     foreach (int score in studentScores)// loop through scores array and complete calculations for currentStudent
//     {

//         gradedAssignments += 1;// increment the assignment counter

//         if (gradedAssignments <= examAssignments)

//             sumAssignmentScores += score;// add the exam score to the sum

//         else
//             sumAssignmentScores += score / 10;// add the extra credit points +10% of an exam score
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();


//-----------------------------------------EXERCISE NESTED LOOPS
/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

//required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
string? myInput = Console.ReadLine();
