
namespace Ex0 
{
    public class Year
    {
        public static void Main(string[] args)
        {
            Year year = new Year();
            var input = Console.ReadLine();
            int inputYear;

            bool isInt = Int32.TryParse(input, out inputYear);

            bool leapYear = year.IsLeapYear(inputYear);
            if(isInt)
            {
                if(inputYear >= 1582)
                {
                    if(leapYear)
                    {
                     Console.WriteLine("yay");
                    }
                    else
                    {
                        Console.WriteLine("nay");
                    }
                }
                else
                {
                    Console.WriteLine("Input invalid. Please only enter years starting from 1582. Please ONLY input integer numbers.");
                }  
            }
            else
            {
                Console.WriteLine("Input invalid. Please only enter years starting from 1582. Please ONLY input integer numbers.");
            }
            
        }


        public bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
