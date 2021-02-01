using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the triangle:");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(n);
            Console.WriteLine();

            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            PrintPellSeries(n2);
            Console.WriteLine();

            //Question 3:
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = SquareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = DiffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);

            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);

            //Question 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);

        }
    }
    /// <summary>
    ///Print a pattern with n rows given n as input
    ///n – number of rows for the pattern, integer (int)
    ///This method prints a triangle pattern.
    ///For example n = 5 will display the output as: 
    ///     *
    ///    ***
    ///   *****
    ///   *******
    ///  *********
    ///returns      : N/A
    ///return type  : void
    /// </summary>
    /// <param name="n"></param>
    private static void PrintTriangle(int n)
    {
        try
        {
            // initialize variables
            int space, len = 1, count;
            Console.WriteLine("Enter same number again: ");
            count = Convert.ToInt32(Console.ReadLine());
            space = count - 1;
            // start of outer for loop
            for (int i = 1; i <= count; i++)
            { //start inner for loops to:
              // print space; p for point space
                for (int p = 1; p <= space; p++)
                {
                    Console.Write(" ");
                }
                // print stars; s for stars
                for (int s = 1; s <= len; s++)
                {
                    Console.Write("*");
                }
                // decrease space, add 2 stars to length each row
                space--;
                len = len + 2;
                Console.WriteLine();
            }
            //Display results in console/terminal
            Console.ReadLine();
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    ///<para>
    ///In mathematics, the Pell numbers are an infinite sequence of integers.
    ///The sequence of Pell numbers starts with 0 and 1, and then each Pell number is the sum of twice of the previous Pell number and 
    ///the Pell number before that.:thus, 70 is the companion to 29, and 70 = 2 × 29 + 12 = 58 + 12. The first few terms of the sequence are :
    ///0, 1, 2, 5, 12, 29, 70, 169, 408, 985, 2378, 5741, 13860,… 
    ///Write a method that prints first n numbers of the Pell series
    /// Returns : N/A
    /// Return type: void
    ///</para>
    /// </summary>
    /// <param name="n2"></param>
    private static void PrintPellSeries(int n2)
    {
        try
        {
            // initialize variables
            int pCounter;
            int pMinusOne = 0;
            int pMinusTwo = 1;
            int pNumber = 0;

            //Console.WriteLine("Find the first 20 numbers: ");
            //Console.WriteLine("Find the first n numbers of Pell series: ");
            //pCounter = Convert.ToInt32(Console.ReadLine());

            //loop for rest of numbers
            for (pCounter = 1; pCounter <= n2; pCounter++)
            {
                // Pell number calculation: P(n) = (2 * P(n-1)) + P(n-2)
                pNumber = (2 * pMinusOne) + pMinusTwo;

                //Assign (n-1)th number as (n-2)th number for next loop
                pMinusTwo = pMinusOne;

                //Assing nth number as (n-1)th number for next loop
                pMinusOne = pNumber;

                Console.WriteLine(pNumber);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }


    /// <summary>
    ///Given a non-negative integer c, decide whether there're two integers a and b such that a^2 + b^2 = c.
    ///For example:
    ///Input: C = 5 will return the output: true (1*1 + 2*2 = 5)
    ///Input: C = 3 will return the output : false
    ///Input: C = 4 will return the output: true
    ///Input: C = 1 will return the output : true
    ///Note: You cannot use inbuilt Math Class functions.
    /// </summary>
    /// <param name="n3"></param>
    /// <returns>True or False</returns>

    private static bool SquareSums(int n3)
    {
        try
        { // initialize new variables
            int a, b, c = 1;
            //start of outer for loop
            // increase counter for variable a
            for (a = 1; a * a <= c; a++)
            { // increase counter for variable b
                for (b = 1; b * b <= c; b++)
                { // if a square plus b squared is equal to c squared
                    if (a * a + b * b == c * c)
                    {
                        Console.Write(a + "^2 + " + b + "^2");
                        //Console.WriteLine("True");
                        return true;
                    }
                    else //return false to try again
                    {
                        //Console.WriteLine("False");
                        return false;
                        throw new Exception("Try again");
                    }
                } //return true;
            }
            return true;
            //Console.ReadLine();
        }
        catch (Exception)
        {
            //Console.WriteLine(e.Message);
            throw;
        }
    }

    /// <summary>
    /// Given an array of integers and an integer n, you need to find the number of unique
    /// n-diff pairs in the array.Here a n-diff pair is defined as an integer pair (i, j),
    ///where i and j are both numbers in the array and their absolute difference is n.
    ///Example 1:
    ///Input: [3, 1, 4, 1, 5], k = 2
    ///Output: 2
    ///Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
    ///Although we have two 1s in the input, we should only return the number of unique   
    ///pairs.
    ///Example 2:
    ///Input:[1, 2, 3, 4, 5], k = 1
    ///Output: 4
    ///Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and
    ///(4, 5).
    ///Example 3:
    ///Input: [1, 3, 1, 5, 4], k = 0
    ///Output: 1
    ///Explanation: There is one 0-diff pair in the array, (1, 1).
    ///Note : The pairs(i, j) and(j, i) count as same.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns>Number of pairs in the array with the given number as difference</returns>
    private static int DiffPairs(int[] nums, int k)
    {
        try
        {
            // Find an array pair where i and j are both numbers
            //in the array and their absolute difference is n

            //initialize variables
            int count = 0;
            int i = 0;
            //int j = 0;
            int temp;
            int x = nums.Length;
            //sort array in ascending order
            Array.Sort(nums);
            //start for loop
            for (i = 0; i < x; i++)
            { // temporary array holder for sorting through first number
                temp = nums[i];
                // inner for loop to sort through second number to find diff
                for (int j = i + 1; j < x; j++)
                { //k is negative here to negate absolute value
                  //not considering negative numbers when entering absolute difference
                    if (temp - nums[j] == -k)
                    { // keep counting, until end of array, then break
                        count++;
                        break;
                    }
                }
            }
            //return to main method
            return count;
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            throw;
        }
    }

    /// <summary>
    /// An Email has two parts, local name and domain name. 
    /// Eg: rocky @usf.edu – local name : rocky, domain name : usf.edu
    /// Besides lowercase letters, these emails may contain '.'s or '+'s.
    /// If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.
    /// For example, "bulls.z@usf.com" and "bullsz@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)
    /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example ro.cky+bulls @usf.com will be forwarded to rocky@email.com.  (Again, this rule does not apply for domain names.)
    /// It is possible to use both of these rules at the same time.
    /// Given a list of emails, we send one email to each address in the list.Return, how many different addresses actually receive mails?
    /// Eg:
    /// Input: ["dis.email+bull@usf.com","dis.e.mail+bob.cathy@usf.com","disemail+david@us.f.com"]
    /// Output: 2
    /// Explanation: "disemail@usf.com" and "disemail@us.f.com" actually receive mails
    /// </summary>
    /// <param name="emails"></param>
    /// <returns>The number of unique emails in the given list</returns>

    private static int UniqueEmails(List<string> emails)
    {
        try
        { // initialize variables
            string local, domain, final;
            //initialize final email list variable
            List<string> final_list = new List<string>();

            // use a foreach loop to execute a block of statements
            // for each element in instance of string
            foreach (string e in emails)
            { // if string contains @, add to index of domain, and take
              // out from local index
                int index = e.IndexOf("@");
                local = e.Substring(0, index - 1);
                domain = e.Substring(index + 1);
                // if local string contains ., replace with an empty space
                // anything with . will be added to list
                if (local.Contains("."))
                {
                    local.Replace(".", string.Empty);
                }
                else
                { //if local string contains none of the above, continue
                    local = local;
                }
                // if local string contains +, add to index of +
                // note that everything after + will be ignored
                if (local.Contains("+"))
                {
                    local = local.Substring(0, e.IndexOf("+"));
                }
                else
                {//if local string contains none of the above, continue
                    local = local;
                }
                // final index should have local, @ and domain to final list
                final = local + "@" + domain;
                final_list.Add(final);
            }
            //initialize result from finals list, and count unique strings
            int result = (from x in final_list select x).Distinct().Count();

            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    /// <summary>
    /// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
    /// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
    /// Example 1:
    /// Input: paths = [["London", "New York"], ["New York","Tampa"], ["Delhi","London"]]
    /// Output: "Tampa" 
    /// Explanation: Starting at "Delhi" city you will reach "Tampa" city which is the destination city.Your trip consist of: "Delhi" -> "London" -> "New York" -> "Tampa".
    /// Input: paths = [["B","C"],["D","B"],["C","A"]]
    /// Output: "A"
    /// Explanation: All possible trips are: 
    /// "D" -> "B" -> "C" -> "A". 
    /// "B" -> "C" -> "A". 
    /// "C" -> "A". 
    /// "A". 
    /// Clearly the destination city is "A".
    /// </summary>
    /// <param name="paths"></param>
    /// <returns>The destination city string</returns>
    private static string DestCity(string[,] paths)
    {
        try
        {
            // initialize variables
            int d;
            string result = " ";
            // initalize string from start to end destinations
            List<string> startDest = new List<string>();
            List<string> finalDest = new List<string>();

            //start for loop to get length of destination path
            // from start to finish
            for (d = 0; d < paths.GetLength(0); d++)
            { //add start/end paths to destination index
                startDest.Add(paths[d, 0]);
                finalDest.Add(paths[d, 1]);
            }
            // use a foreach loop to execute a block of statements
            // for each element in instance of string in final index list
            foreach (string element in finalDest)
            { // if starting destination has final element (not duplicate
              // from last index, as from start)
                if (startDest.Contains(element))
                {
                    continue;
                }
                // break if final destination reached
                else
                {
                    result = element;
                    break;
                }
            }
            //output final destination result
            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
