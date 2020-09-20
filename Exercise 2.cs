using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace EcceptionDemo
{

    public class InvalidDataException : Exception
    {
        public InvalidDataException(string msg)
            : base(String.Format("Invalid Data Entry: {0}", msg))
        {
        }
    }
    public class Student
    {
        string uid, name, email;
        int semester;

        public void readDate()
        {
            try
            {
                Console.Write("Enter UID: ");
                uid = Console.ReadLine();

                if (!uid.All(char.IsLetterOrDigit))
                {
                    throw new InvalidDataException("Please Enter Alphanumeric Characters Only");
                }
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                if (!name.All(char.IsLetter))
                {
                    throw new InvalidDataException("Please Enter Letters Only");
                }
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.Write("Enter Semester: ");
                semester = Convert.ToInt32(Console.ReadLine());
                throw new InvalidDataException("Please Enter Digits Only");
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.Write("Enter Email ID: ");
                email = Console.ReadLine();
                int count = 0;

                foreach (var item in email)
                {
                    if (item.Equals("@"))
                    {
                        count += 1;
                    }
                }

                if (count != 1)
                {
                    throw new InvalidDataException("Please Enter Valid Email");
                }
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void displayData()
        {
            Console.WriteLine("Name:  {0}", name);
            Console.WriteLine("UID:  {0}", uid);
            Console.WriteLine("Semester:  {0}", semester);
            Console.WriteLine("Email ID:  {0}", email);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.readDate();
            s.displayData();
        }
    }
}
