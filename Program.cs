using System;
using System.Linq;

namespace DIS_Assignment1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            int len = s.Length;
            if (len <= 10000)
            {
                string final_string = RemoveVowels(s);
                Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lenght of input string should be less than 10000");
            }


            //NEXT

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //NEXT

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            //NEXT

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //NEXT

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: {0}", rotated_string);
            Console.WriteLine();

            //NEXT

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();
        }
        //RemoveVowels Vowels Function
        private static string RemoveVowels(string s)
        {
            try
            {
                String input = s;
                String final_string = "";
                int length = input.Length;
                //Create a array of upper and lower case vowels
                char[] ch = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                //final_string = Regex.Replace(input, "[aeiouAEIOU]", "");
                //for each character in the array check if the input character is a vowel

                for (int i = 0; i < input.Length; i++)
                {
                    //if the character is a vowel add nothing to the final_string
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' ||
                    input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' ||
                    input[i] == 'O' || input[i] == 'U')
                    {
                        final_string += "";
                    }
                    //if the character is not a vowel add it to the final_string
                    else
                    {
                        final_string += input[i];
                    }
                }
                //return the final string without vowels to the fucntion call
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Check if two strings are equal
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                /*Two input strings are declared and the elements of the string
                array are concatenated to form one word for comparison*/
                string input1 = "";
                string input2 = "";
                foreach (string input in bulls_string1)
                {
                    input1 += input;
                }

                foreach (string input in bulls_string2)
                {
                    input2 += input;
                }
                //The two strings are compared and if equal it return True else False
                if (input1 == input2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //calculate length of the input array
                int len = bull_bucks.Length;
                //declare an array sample of length same as length len
                int[] sample = new int[len];
                int sum = 0;
                for (int i = 0; i < len; i++)
                {
                    int n = bull_bucks[i];

                    /*checking if the sample array contains the element in the bull_bucks array.
                    if not, add the element*/

                    if (sample.Contains(n))
                    {
                        sum -= n;
                    }
                    else
                    {
                        //calculate the sum of the unique elements
                        sample[i] = bull_bucks[i];
                        sum += n;

                    }
                }
                return sum;
            }
            catch
            {
                throw;
            }
        }
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                /*calculate length of the array*/
                int len = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));
                int sum = 0;
                //Looping through the index for each row in the matrix
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        //for the element equal to the row number
                        if (i == j)
                        {
                            sum += bulls_grid[i, j];
                        }
                        else if (i + j == (len - 1))
                        {
                            sum += bulls_grid[i, j];
                        }
                    }
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                int len = indices.Length;
                string result = "";
                for (int i = 0; i < len; i++)
                {
                    int n = Array.IndexOf(indices, i);
                    result += bulls_string[n];
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //
                String prefix_string = "";
                int len = bulls_string6.Length;
                int n = bulls_string6.IndexOf(ch, 0, len);

                //starting from the last digit and reversing till the character ch 'c'
                for (int i = n; i >= 0; i--)
                {
                    prefix_string += bulls_string6[i];
                }
                //Adding the characters after the reversed characters as is
                for (int i = n + 1; i < len; i++)
                {
                    prefix_string += bulls_string6[i];
                }
                return prefix_string;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}