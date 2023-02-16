/*
 * Author: Elieser Myrtil
 * Date: 02/15/2023
 * This program is responsible for taking the input from a user and selecting the corresponding
 * number of elements which will be totaled up at the end of the program.
 */

namespace Deliverable__5__Methods_Myrtil_Elieser
{
    internal class Program
    {
        //Helps declare and randomize the array and work with the input that the user will be putting in
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        //Function below is responsible for summing the calculation of the elements in the array
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        // Takes the numerical value of the user and random selects the elements of an array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 5 and 15");
            int input = int.Parse(Console.ReadLine());
            int[] MyArray = random_array(input);
            Console.Write("The elements in the random array are: ");
            foreach (int i in MyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("The sum is : " + sum(MyArray));
        }
    }
}
