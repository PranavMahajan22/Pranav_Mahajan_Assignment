namespace Question2_LargestNumber
{
    internal class Question2_LargestNumber
    {
        //2. Write a program to find the largest number in an array.
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Invalid array size");
                return; // Exit if size is invalid
            }
            //// Declare array with given size
            int[] arr = new int[num];

            // Input
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Assume first element is the maximum
            int max = arr[0];

            for (int i = 1; i < num; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Maximum number in array is: " + max);

        }
    }
}
