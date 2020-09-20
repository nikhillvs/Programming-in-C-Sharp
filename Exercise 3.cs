using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exrecise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int yob;   //year of birth
            int mob;   //month of birth
            int dob;   //date of birth
            Console.WriteLine("Enter the year of birth");
            yob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month of birth");
            mob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of birth");
            dob = Convert.ToInt32(Console.ReadLine());

            int rcode = CheckTheBirthDate(yob, mob, dob);
            switch (rcode)
            {
                case 0:
                    Console.WriteLine("hey you are born today.Welcome!!!");
                    break;
                case 1:
                    Console.WriteLine("you have entered a future date....");
                    break;
                case 2:
                    Console.WriteLine("your are lucky to have lived >=135");
                    break;
                default:
                    Console.WriteLine("your age is " + rcode);
                    if (TodayBirthday(mob, dob))
                        Console.WriteLine("Happy BirthDay");
                    Console.WriteLine(DisplayAstrologicalsign(mob, dob));
                    break;
            }
            Console.ReadLine();


        }

        private static string DisplayAstrologicalsign(int mob, int dob)
        {
            switch (mob)
            {
                case 1:
                    if (dob <= 20)
                    {
                        return "capricorn";
                    }
                    else
                        return "aquarius";
                case 2:
                    if (dob <= 18)
                    {
                        return "aquaris";
                    }
                    else
                        return "pisces";
                case 3:
                    if (dob <= 20)
                    {
                        return "pisces";
                    }
                    else
                        return "Aries";
                case 4:
                    if (dob <= 20)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (dob <= 21)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (dob <= 21)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (dob <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (dob <= 23)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (dob <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (dob <= 23)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (dob <= 22)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (dob <= 21)
                        return "Sagittarius";
                    else
                        return "Capricorn";
                default: return "null";
            }
        }

        private static bool TodayBirthday(int mob, int dob)
        {
            DateTime tdy = DateTime.Today;
            if (mob == tdy.Month && dob == tdy.Day)
                return true;
            else
                return false;
        }

        private static int CheckTheBirthDate(int yob, int mob, int dob)
        {
            DateTime bDate = new DateTime(yob, mob, dob);
            DateTime tdate = DateTime.Today;
            int rValue = DateTime.Compare(bDate, tdate);
            if (rValue < 0)
            {
                if ((tdate.Year - bDate.Year) >= 135)
                    return 2;
                else
                    return (tdate.Year - bDate.Year);
            }
            else if (rValue > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
    }
}
