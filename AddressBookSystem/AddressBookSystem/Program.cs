using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("!------Welcome to Address Book system------!");
            //creating object of addressbook
            AddressBook addressBook = new AddressBook();
            //getting Op in Constructor with paratmers
            addressBook.addContacts("Shreya", "Malviya", "Anc", "Nagpur", "MH", 440022, 01234567890, "abcd@gmail.com");
            // called Print method 
            addressBook.print();
            Console.ReadLine();
        }
    }
}
