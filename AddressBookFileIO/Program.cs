﻿using AddressBookFileIO.FileIoOperation;

namespace AddressBookFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Sartaj khan\source\repos\AddressBookFileIO\AddressBookFileIO\MyFiles\Contacts.txt";

            PersonInput input = new PersonInput();
            Console.WriteLine("\nEnter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();

            FileIO.WriteRecordsInFile(path, input);
            Console.WriteLine("\n\nRecords present in file are : ");
            FileIO.ReadRecordsFromFile(path);
            Console.ReadLine();
        }
    }
}