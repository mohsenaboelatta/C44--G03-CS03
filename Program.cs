using System;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter a number : ");
            ///int x;
            //int.TryParse(Console.ReadLine(), out x);
            //Console.WriteLine($"The number is: {x}");
            #endregion
            #region 2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen.
            //string str = "112345asdf";
            //int result = Convert.ToInt32(str);
            ////////Unhandled exception. System.FormatException: The input string '112345asdf' was not in a correct format.
            #endregion
            #region 3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //double myDouble = 10.5;
            //double myDouble2 = 4;
            //double myDouble3 = 2.4;
            //double sum = myDouble + myDouble2 + myDouble3;

            //Console.WriteLine( sum);
            #endregion
            #region 4.Write C# program that Extract a substring from a given string.
            //string x = "Mohsen Abo Elatta";
            //string subx = x.Substring(0, x.Length - 5);
            //Console.WriteLine(subx);


            #endregion
            #region 5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 8;
            //int y = 10;
            //y = x;
            //y = 91;

            //Console.WriteLine( $"x = {x} , y = {y}");
            #endregion
            #region 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;

            //arr2[0] = 8;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            #endregion
            #region 7.Write C# program that take two string variables and print them as one variable 
            //string f = "Mohsen";
            //string l = "AboElatta";
            //Console.WriteLine(f +" "+ l);
            #endregion
            #region 8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            // Note: The formula for simple interest is Interest = (principal * rate * time) / 100.

            //double principal = 100;
            //double rate = 8;          
            //double time = 2;         

            //double  simple_interest = (principal * rate * time) / 100;

            //Console.WriteLine($"{simple_interest}");


            #endregion
            #region 9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            //double weight = 90;
            //double height = 1.75;

            //double BMI = weight / (height * height);

            //Console.WriteLine($"{BMI}");

            #endregion
            #region 10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            //Note:
            //    a.that below 10 degrees is "Just Cold"
            //    b.above 30 degrees is "Just Hot"
            //    c.anything else is "Just Good"
            //Console.Write("Enter Temperature: ");
            //int.TryParse(Console.ReadLine(), out int temp);

            //switch (temp)

            //{
            //    case < 10:
            //        Console.WriteLine("Just Cold");
            //        break;
            //    case > 30:
            //        Console.WriteLine("Just Hot");
            //        break;
            //    default:
            //        Console.WriteLine("Just Good");
            //        break;
            //}

            #endregion
            #region 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //    Today’s date : 20 , 11 , 2001
            //    Today's date : 20 / 11 / 2001
            //    Today's date : 20 – 11 – 2001
            //Console.Write("Day is : ");
            //int.TryParse(Console.ReadLine(), out int day);

            //Console.Write("Month is : ");
            //int.TryParse(Console.ReadLine(), out int month);

            //Console.Write("Year is : ");
            //int.TryParse(Console.ReadLine(), out int year);

            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");
            #endregion
            #region 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //        Example(1)
            //        Input: 12
            //        Output: Yes
            //        Example(2)
            //        Input: 9
            //        Output: No

            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else if (number > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine("Enter the Correct Number");
            //}


            #endregion
            #region 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //             Example(1)
            //             Input: 7,8,5
            //             Output:
            //             max element = 8
            //             min element = 5
            //—--------------------------------
            //             Example(2)
            //             Input: 3 6 9
            //             Outputs:
            //             Max element = 9
            //             Min element = 3
            //Console.Write("Enter first number  : ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("Enter second number : ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //Console.Write("Enter third number  : ");
            //int.TryParse(Console.ReadLine(), out int num3);
            //int max = num1;
            //int min = num1;

            //if (num1 > max)
            //    max = num1;
            //if (num1 < min)
            //    min = num1; 

            //if (num2 > max)
            //    max = num2;
            //if (num3 > max)
            //    max = num3;

            //if (num2 < min)
            //    min = num2;
            //if (num3 < min)
            //    min = num3;

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");


            #endregion
            #region 15- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter an Integer Number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            #endregion
            #region 16- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Example(1)
            //Input: O
            //Output: vowel
            //Example(2)
            //Input: b
            //Output: Consonant

            //Console.Write("Enter One Character: ");
            //char.TryParse(Console.ReadLine(), out char ch);

            //ch = char.ToLower(ch);

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}

            //else
            //{
            //    Console.WriteLine("Consonant");
            //}


            #endregion
            #region 17- Write a program to input the month number and print the number of days in that month.
            //Example
            //Input: Month Number: 1
            //Output: Days in Month: 31
            #region Days In Month (Using If Else)

            //Console.Write("Enter Month Number : ");
            //int.TryParse(Console.ReadLine(), out int month);

            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //{
            //    Console.WriteLine("Days in this Month: 31");
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    Console.WriteLine("Days in this Month: 30");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Days in this Month: 28 or 29");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Month Number!");
            //}
            //
            #endregion

            #endregion



        }
    }
}
