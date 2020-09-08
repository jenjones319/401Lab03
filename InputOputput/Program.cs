namespace System.IO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Challenge2();
            Challenge3();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
        }

        // Find  the product of first three numbers in an array
        public static int Challenge1(int[] array)
        {
            if (array.Length < 3)
                return 0;
            else
            {
                int total = 1;
                for (int i = 0; i < 3; i++)
                {
                    total *= array[i];
                }
                return total;
            }

        }

        // Find  the average of numbers entered by user
        public static void Challenge2()
        {
            Console.Write("Please enter a number between 2-10: ");
            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(input);
            int[] array = new int[inputNum];
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} of {1} - Enter a number: ", i + 1, inputNum);
                string input2 = Console.ReadLine();
                int inputNum2 = Convert.ToInt32(input2);
                array2[i] = inputNum2;
            }
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum += array2[i];
            }
            int avg = sum / array2.Length;
            Console.WriteLine("The average of these {0} numbers is: {1}", array2.Length, avg);
        }

        // Draw a diamond with *
        public static void Challenge3()
        {
            int i, j, k;

            for (i = 1; i <= 5; i++)
            {
                for (j = 0; j < (5 - i); j++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                for (k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (i = 5 - 1; i >= 1; i--)
            {
                for (j = 0; j < (5 - i); j++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                for (k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        // Find the most frequent number in an array
        public static int Challenge4(int[] arr)
        {

            int n = arr.Length;

            // Sort the array 
            Array.Sort(arr);

            // Find the max frequency
            int max_count = 1, res = arr[0];
            int curr_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent 
            if (curr_count > max_count)
            {
                res = arr[n - 1];
            }

            return res;
        }

        // Find the biggest number in the array
        public static int Challenge5(int[] array)
        {
            int bigNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > bigNum)
                {
                    bigNum = array[i];
                }
            }
            return bigNum;
        }

        // Write words input by user to txt file
        public static void Challenge6()
        {
            Console.WriteLine("Enter one or more words to write to words.txt, seperated by spaces");
            string input = Console.ReadLine() + " was entered by user.";

            string path = "/Users/kdonahe/desktop/401_Projects/Lab03-SystemIO/words.txt";

            File.WriteAllText(path, input);

        }

        // Read the words in the text file
        public static void Challenge7()
        {
            const string path = "/Users/kdonahe/desktop/401_Projects/Lab03-SystemIO/words.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.ReadLine();
        }

        // Replace the first word in the text file
        public static void Challenge8()
        {
            const string path = "/Users/kdonahe/desktop/401_Projects/Lab03-SystemIO/words.txt";
            string text = File.ReadAllText(path);

            string firstWord = text.Substring(0, text.IndexOf(" "));
            string newWord = "REPLACED";

            string newText = newWord + text.Remove(0, firstWord.Length);
            File.WriteAllText(path, newText);

            Console.WriteLine("The first word written has been replaced in the root txt file. Open your file explorer to see the change.");
            Console.WriteLine();
        }

        // Write each word entered with their lengths
        public static void Challenge9()
        {
            Console.WriteLine("Type a sentence here:");
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            Console.WriteLine("The follow are the words entered and their lengths:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}: {1}", array[i], array[i].Length);
            }
            Console.WriteLine();
            Console.WriteLine("Application complete!");
            Console.ReadLine();
        }
    }
}
