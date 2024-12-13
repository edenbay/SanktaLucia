namespace Uppgifter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Provkör gärna. För att få se ditt resultat använder du antingen
            //breakpoints eller Console.WriteLine()
        }


        //Create a function that takes a number(from 1 to 12) and returns its corresponding month name as a string. 
        //For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
        public static string MonthName(int monthNumber)
        {
            return monthNumber switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December"
            };
        }

        //Write a function that converts hours into seconds.
        //60 seconds in a minute, 60 minutes in an hour.
        //Don't forget to return your answer.
        public static int HowManySeconds(int hours) => (hours * 60) * 60;

        //Create a function that takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz".
        //    If the number is a multiple of 3 the output should be "Fizz".
        //    If the number given is a multiple of 5, the output should be "Buzz".
        //    If the number given is a multiple of both 3 and 5, the output should be "FizzBuzz".
        //    If the number is not a multiple of either 3 or 5, the number should be output on its own as shown in the examples below.
        //    The output should always be a string even if it is not a multiple of 3 or/and 5.
        public static string FizzBuzz(int number)
        {
            bool multipleOfThree = number % 3 == 0;
            bool multipleOfFive = number % 5 == 0;
            if (multipleOfThree || multipleOfFive)
            {
                if (multipleOfThree && !multipleOfFive)
                    return "Fizz";
                if (multipleOfFive && !multipleOfThree)
                    return "Buzz";

                return "FizzBuzz";
            }
            return number.ToString();

        }
    }
}
