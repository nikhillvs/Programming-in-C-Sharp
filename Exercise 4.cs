using person;
using System;
using System.Runtime.Versioning;

namespace person
{
    class Person
    {
        private string firstname;
        private string lastname;
        private string emailid;
        private DateTime dob;

        public Person(string firstname, string lastname, string emailid, string dOB)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailid = emailid;
        }

        public Person(string firstname, string lastname, DateTime dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
        }

        public Person(string firstname, string lastname, string emailid, DateTime dob)
        {
            this.dob = dob;
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailid = emailid;
        }

        public DateTime DOB { get => dob; set =>dob = value;}
        public string EmailAdress { get => emailid; set => emailid = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }

        public bool adult
        {
            get
            {
                if ((DateTime.Today.Year - dob.Year) >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string Sunsign
        {
            get
            {
                switch (dob.Month)
                {
                    case 1:
                        if (Convert.ToInt32(dob.Date) <= 20)
                        {
                            return "capricorn";
                        }
                        else
                            return "aquarius";
                    case 2:
                        if (Convert.ToInt32(dob.Date) <= 18)
                        {
                            return "aquaris";
                        }
                        else
                            return "pisces";
                    case 3:
                        if (Convert.ToInt32(dob.Date) <= 20)
                        {
                            return "pisces";
                        }
                        else
                            return "Aries";
                    case 4:
                        if (Convert.ToInt32(dob.Date) <= 20)
                            return "Aries";
                        else
                            return "Taurus";
                    case 5:
                        if (Convert.ToInt32(dob.Date) <= 21)
                            return "Taurus";
                        else
                            return "Gemini";
                    case 6:
                        if (Convert.ToInt32(dob.Date) <= 21)
                            return "Gemini";
                        else
                            return "Cancer";
                    case 7:
                        if (Convert.ToInt32(dob.Date) <= 22)
                            return "Cancer";
                        else
                            return "Leo";
                    case 8:
                        if (Convert.ToInt32(dob.Date) <= 23)
                            return "Leo";
                        else
                            return "Virgo";
                    case 9:
                        if (Convert.ToInt32(dob.Date) <= 22)
                            return "Virgo";
                        else
                            return "Libra";
                    case 10:
                        if (Convert.ToInt32(dob.Date) <= 23)
                            return "Libra";
                        else
                            return "Scorpio";
                    case 11:
                        if (Convert.ToInt32(dob.Date) <= 22)
                            return "Scorpio";
                        else
                            return "Sagittarius";
                    case 12:
                        if (Convert.ToInt32(dob.Date) < 22)
                            return "Sagittarius";
                        else
                            return "Capricorn";
                    default: return "null";
                }
            }
        }

        public bool BirthDay
        {
            get
            {
                if ((dob.Month ==DateTime.Today.Month) && (dob.Date ==DateTime.Today.Date))
                    return true;
                else
                    return false;
            }
        }

        public string ScreenName 
        {
            get
            {
                string screenName;
                screenName = firstname.Substring(0, 1) + dob.Month.ToString();
                return screenName;
            }  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        string fname, lname, email,DOB;

        System.Console.WriteLine("Enter the first name");
        fname = Console.ReadLine();
        System.Console.WriteLine("Enter the last name");
        lname = Console.ReadLine();
        System.Console.WriteLine("Enter the email address");
        email = Console.ReadLine();
        System.Console.WriteLine("Enter the date of birth");
        DOB = Console.ReadLine();

            DateTime dT = new DateTime(Convert.ToInt32(DOB.Substring(0, 4)), Convert.ToInt32(DOB.Substring(4, 2)), Convert.ToInt32(DOB.Substring(6, 2)));

            Person p1= new Person(fname, lname, email, DOB);
        Console.WriteLine("The person is adult? :" + p1.adult);
        Console.WriteLine("The Sunsign:" + p1.Sunsign);
        Console.WriteLine("today is birthday?:" + p1.BirthDay);
        Console.WriteLine("The allotted Screen name:" + p1.ScreenName);
        
        }
    }
}
