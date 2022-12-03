namespace practice
{

    public class Ifstatement
    {

        public static void Main()
        {
            Console.WriteLine(" Please enter a number");
            int username= int.Parse(Console.ReadLine());

            if (username == 1)
            {
                Console.WriteLine("your input is one");
            }

            else if (username == 2)
            {
                Console.WriteLine("your input is two");
            }

            else if (username == 3)
            {
                Console.WriteLine("your input is three");
            }
            else
            {
                Console.WriteLine("your input is not between 1-3");
            }
        }
    }
}