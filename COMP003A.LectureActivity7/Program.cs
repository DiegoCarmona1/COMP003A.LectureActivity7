/*
 * Author: Diego Carmona
 * Course: COMP-003A
 * Purpose: To gain understanding and familiarity in utilizing and recognizing Big O notation, arrays, and lists, and the differences between.
 */

namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Arrays");
            // arrays store a collection of data of the same type (e.g., int, string, objects, etc.)
            // array1 declaration and setting values
            int[] array1 = new int[5]; // declare a single-dimensional array of 5 integers without values
            // you can set values to an index using the examples below:
            array1[0] = 5; // sets the value for index 0 to 5
            array1[1] = 10; // sets the value for index 1 to 10
            array1[2] = 15; // sets the value for index 2 to 15
            array1[3] = 20; // sets the value for index 3 to 20
            array1[4] = 25; // sets the value for index 4 to 25

            Console.WriteLine($"Length of array1: {array1.Length}\n"); // displays the length/size of the array; output: 5


            // array2 declaration with values

        }
    }
}
