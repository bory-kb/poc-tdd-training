namespace poc_tdd_training
{

    public class FizzBuzz
    {
        public static void Main()
        {
        }

        public string Convert(int num)
        {
            if(num % 3 == 0)
            {
                return "Fizz";
            }
            
            return num.ToString();
        }
    }
}