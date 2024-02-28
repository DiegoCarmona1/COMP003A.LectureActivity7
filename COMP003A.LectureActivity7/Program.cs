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
            int[] array2 = new int[] { 1, 3, 5, 7, 9 }; // declares a single-dimensional array element with values

            /* arrays are zero-indexed, meaning the first 'position' starts at index 0
             * values in an array can be accessed using the syntax below:
             * arrayName[indexNumber]
             * 
             * e.g.,
             * int[] array2 = new int[] { 1, 3, 5, 7, 9 };
             * array2[0] -> returns 1
             * array2[1] -> returns 3
             * array2[2] -> returns 5
             * array2[3] -> returns 7
             * array2[4] -> returns 9
             * array2[5] -> RUNTIME ERROR: OutOfBoundsException
             * 
             * It is important to note that arrays cannot be dynamically resized.
             * They are stored in sequential blocks of memory, making it extremely fast to access them.
             * Also, you will get a runtime error of OutOfBoundsException
             * when accessing an index that does not exist
             */
            Console.WriteLine("array2 Traversal");
            ArrayTraversal(array2);


            // integer array traversal
            int[] grades = new int[] { 100, 85, 92, 87, 91, 78, 89 };
            Console.WriteLine($"\ngrades Average: {GetAverage(grades)}");


            // string array traversal
            Console.WriteLine("\nstring Traversal");
            // strings are special object consisting of an array of characters
            string message = "hello";
            ArrayTraversal(message);


            SectionSeparator("Lists");
        }
    }
}
