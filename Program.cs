namespace Roman_Numeral_Converter___Algorithm_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GOAL: Create a method that takes in an integer from the user, then converts that integer to its Roman numeral equivalent, up to a max of 10,000.
            //Note: The data type of the resultant numeral is a string.

            //1) Create a dictionary, or group of lists for each tens place, which binds the values of the Roman symbols to their numeric counterparts.

            //2) Convert the user's numeric input into a string.
            //3) Check the length of the user's input. Given the length, this will determine the Numeral needed to start (i.e. 4 digits = thousands, 3 digits = hundreds);
            //4) From left to right, add in the characters that would represent the necessary amount.
            //5) Display the resultant output string to the user.

            bool goOn = true;

            while (goOn)
            {
                NumberConverter n = new NumberConverter();

                Console.WriteLine("Please enter a non-negative whole number that you'd like to convert into Roman Numerals:\n");

                int input = int.Parse(Console.ReadLine());

                string output = n.ConvertToRomanNum(input);

                Console.WriteLine($"\nYour number in Roman Numerals is: \n\n{output}\n");

                goOn = AskToGoOn();
            }

        }

        public static bool AskToGoOn()
        {
            Console.WriteLine("\nWould you like convert another number? Please enter yes (Y) or no (N).\n");

            string input = Console.ReadLine().ToLower();

            if (input == "Y" || input == "y" || input == "yes")
            {
                Console.WriteLine("\nAlright! Let's convert another number!\n");
                return true;
            }
            else if (input == "N" || input == "n" || input == "no")
            {
                Console.WriteLine("\nGoodbye!\n");
                return false;
            }
            else
            {
                Console.WriteLine("\nI'm sorry. I didn't understand that. Please try again.\n");
                return AskToGoOn();
            }
        }

    }
}