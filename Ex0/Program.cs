
namespace Ex0 
{
    public class Year
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
