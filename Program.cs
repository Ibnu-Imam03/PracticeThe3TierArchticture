
using ContactBusinessLayer;
using System;
using System.Data;
using System.Diagnostics.Contracts;

namespace ContactConsolApp
{
    internal class Program
    {
        static void testFindContact(int ID)
        {
            clsContact Contact1 =  clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName + " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");
            }

        }

        static void testAddNewContact()
        {
            clsContact Contact1 = new clsContact();
            Contact1.FirstName = "Fadi";
            Contact1.LastName = "Maher";
            Contact1.Email = "A@a.com";
            Contact1.Phone = "010010";
            Contact1.Address = "address1";
            Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";

            if (Contact1.Save())
            {
                Console.WriteLine("Contact Added Successfully with id=" + Contact1.ID);

            }
        }

        static void Main(string[] args)
        {

            //testFindContact(1);
            testAddNewContact();
            //testUpdateContact(1);
            //ListContacts();

            Console.ReadKey();

        }
    }
}