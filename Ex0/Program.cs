
namespace Ex0 
{
    public class Year
    {
        public static void Main(string[] args)
        {
            Year year = new Year();
            var input = Console.ReadLine();
            if(year.IsLeapYear(int.Parse(input)))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
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
