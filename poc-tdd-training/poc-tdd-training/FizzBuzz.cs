namespace poc_tdd_training
{

    public class FizzBuzz
    {
        public static void Main()
        {
        }

        public string Convert(int num)
        {
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }

            return num.ToString();
        }
    }
}