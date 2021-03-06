using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        // adding items mechanism into generic type
        private List<Contact> contactList;
        private object personal_Details;
        internal object addressBook;

        /// <summary>
        /// Class For AddressBook
        /// </summary>
        public AddressBook()
        {
            //instantiate generic with contact string
            contactList = new List<Contact>();
        }
        /// <summary>
        /// Constructor class for addressBook
        ///  // field
        /// </summary>
        /// <param name="fistName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public void addContacts(string fistName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            //UC7
            //bool for duplicate value
            ////using equals method and with parameters firstname and last name
            bool duplicate = equals(fistName, lastName);
            //condtition for check where the entered data is match or not
            // if duplicate is ! same it will enter the record
            if (!duplicate)
            {
                //Create object of Contact class
                Contact contact = new Contact();
                //calling Varivale using object
                contact.fistName = fistName;
                contact.lastName = lastName;
                contact.address = address;
                contact.city = city;
                contact.state = state;
                contact.zip = zip;
                contact.phoneNumber = phoneNumber;
                contact.email = email;
                //adding contact details in contact list 
                contactList.Add(contact);
            }
            // ELSE  it is duplicate contact   
            else
                Console.WriteLine("Cannot add duplicate Contact");
        }

        /// <summary>
        ///This method is used to return a value indicating whether this instance
        ///is equal to a specified Boolean object.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        private bool equals(string fName, string lName)
        {
            // lambda expression is a shorter way of representing anonymous method using some special syntax
            //input => expression;
            // Using Lambda exression to
            //Any: Checks if any elements in a collection satisifies a specified condition.
            if (this.contactList.Any(e => e.fistName == fName && e.lastName == lName))
                return true;
            else
                return false;
        }
        //method print
        public void print()
        {
            //using foreach loop for calling the variable //ref of contact class
            foreach (Contact contact in contactList)
            {
                //Prinitng the Op
                Console.WriteLine("FirstName: " + contact.fistName);
                Console.WriteLine("LastName: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("Zip: " + contact.zip);
                Console.WriteLine("PhoneNumber: " + contact.phoneNumber);
                Console.WriteLine("Email id: " + contact.email);
            }
        }

        /// <summary>
        ///
        /// void as the return type of a method edit with parameter
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void edit(string firstName, string lastName)
        {
            // created object ContacttobeEdited for conatct and at starting it will be null
            Contact contactToBeEdited = null;

            // foreach loop begin
            // it will run till the
            // last element of the array
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                    //otherwise get the value
                    this.editThisContact(contact);

            }
            // if First Name And last name is not match with entered data
            //contactToBeEdited == null
            //if (contactToBeEdited == null)
            //{
            //    //Error :No such contact exists
            //    Console.WriteLine("No such contact exists");
            //    return;
            //}

        }
        /* <summary>
            fetch details and edit This Contact
            Class Contact contactToBeEdited 
           </summary>
            <param name="contactToBeEdited"></param>
        */
        public void editThisContact(Contact contactToBeEdited)
        {
            bool status = true;
            //if true
            while (status == true)
            {
                //Enter what you want to edit
                Console.WriteLine("Enter 1 to edit FirstName");
                Console.WriteLine("Enter 2 to edit LastName");
                Console.WriteLine("Enter 3 to edit Address");
                Console.WriteLine("Enter 4 to edit City");
                Console.WriteLine("Enter 5 to edit State");
                Console.WriteLine("Enter 6 to edit Zip");
                Console.WriteLine("Enter 7 to edit PhoneNumber");
                Console.WriteLine("Enter 8 to edit Email Id");
                Console.WriteLine("Enter 9 if Editing is done");
                Console.WriteLine("Enter 10 if Delete is done");

                //read value
                int choice = Convert.ToInt32(Console.ReadLine());
                //switchCase
                switch (choice)
                {
                    //for Edit FirstName
                    case 1:
                        Console.WriteLine("Enter new FirstName");
                        string fName = Console.ReadLine();
                        contactToBeEdited.fistName = fName;
                        break;
                    //For edit Lastlame
                    case 2:
                        Console.WriteLine("Enter new LastName");
                        string lName = Console.ReadLine();
                        contactToBeEdited.lastName = lName;
                        break;
                    //For Edit Address
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        contactToBeEdited.address = address;
                        break;
                    //For Edit City
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        contactToBeEdited.city = city;
                        break;
                    //For Edit State
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        contactToBeEdited.state = state;
                        break;
                    //For Edit Zip
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        contactToBeEdited.zip = zip;
                        break;
                    ////For Edit Phone NUmber
                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        contactToBeEdited.phoneNumber = phoneNumber;
                        break;
                    //For Edit Email ID
                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        contactToBeEdited.email = email;
                        break;
                    //if Done
                    case 9:
                        Console.WriteLine("Editing done.New Contact :-");
                        this.printSpecificContact(contactToBeEdited);
                        break;

                    //default
                    default:
                        status = false;
                        break;
                }
            }//while end
        }
        //Print Data After Edit
        public void printSpecificContact(Contact contact)
        {
            Console.WriteLine("FirstName: " + contact.fistName);
            Console.WriteLine("LastName: " + contact.lastName);
            Console.WriteLine("Address: " + contact.address);
            Console.WriteLine("City: " + contact.city);
            Console.WriteLine("State: " + contact.state);
            Console.WriteLine("Zip: " + contact.zip);
            Console.WriteLine("PhoneNumber: " + contact.phoneNumber);
            Console.WriteLine("Email id: " + contact.email);
        }
        public void delete(string firstName, string lastName)
        {
            Contact contactToBeDeleted = null;
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                {
                    contactToBeDeleted = contact;
                    this.contactList.Remove(contactToBeDeleted);
                    break;
                }
            }
            if (contactToBeDeleted == null)
                Console.WriteLine("No such contact exists");
            else
                Console.WriteLine("Deletion Done.");
        }

        /// <summary>
        /// UC8
        /// </summary>
        public void Search()
        {
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("1. City 2. State");
            int choiceOne = Convert.ToInt32(Console.ReadLine());
            switch (choiceOne)
            {
                case 1:
                    Console.WriteLine("Enter your City Name:");
                    String NameToSearchInCity = Console.ReadLine();
                    // Using Lambda exression to
                    // find all the matching data  from contact list
                    foreach (Contact personal_Details in this.contactList.FindAll(e => e.city == NameToSearchInCity))
                    {
                        Console.WriteLine("City of " + personal_Details.fistName + personal_Details.lastName + " is : " + personal_Details.city);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your State Name:");
                    String nameToSearchInState = Console.ReadLine();
                    // Using Lambda exression to
                    // find all the matching data  from contact list
                    foreach (Contact personal_Details in this.contactList.FindAll(e => e.state == nameToSearchInState))
                    {
                        Console.WriteLine("City of " + personal_Details.fistName + personal_Details.lastName + " is : " + personal_Details.state);
                    }
                    break;

            }
        }
        public void ViewContact()
        {
            Console.WriteLine("Enter your Choice for Viewing a Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choiceOne = Convert.ToInt32(choice);
            //Using switch case is used to take a input
            switch (choiceOne)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    //(input-parameters) => { <sequence-of-statements> }
                    // which specifies a parameter that's named  e and returns the value of city,s assigned to a variable
                    foreach (Contact contact in this.contactList.FindAll(e => e.city == city))
                        Console.WriteLine("View Person Name" + contact.fistName + contact.lastName);

                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    //(input-parameters) => { <sequence-of-statements> }
                    // which specifies a parameter that's named  e and returns the value of state, assigned to a variable
                    foreach (Contact contact in this.contactList.FindAll(e => e.state == state))
                        Console.WriteLine("View Person Name" + contact.fistName + contact.lastName);
                    break;
            }
        }

        public void CountContacts()
        {
            int count = 0;
            Console.WriteLine("Enter your Choice for Count Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choiceOne = Convert.ToInt32(choice);
            switch (choiceOne)
            {
                case 1:
                    //Input from user
                    Console.WriteLine("Enter your City");
                    //Reading String
                    String city = Console.ReadLine();
                    // loop for find all the list present of city
                    foreach (Contact personal_Details in this.contactList.FindAll(c => c.city == city))
                    {
                        // count return the number of element in a sepuence
                        count = this.contactList.Count();
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Contact personal_Details in this.contactList.FindAll(c => c.state == state))
                    {
                        count = this.contactList.Count();
                    }
                    Console.WriteLine(count);
                    break;
            }
        }
        //public void SortByName()
        //{
        //    contactList.Sort((contact1, contact2) => contact1.fistName.CompareTo(contact2.fistName));
        //    foreach (Contact c in contactList)
        //    {
        //        Console.WriteLine(c.ToString());
        //    }
        //}

        /// <summary>
        /// Views the name of the entries sorted by person name.
        /// </summary>
        public void ViewEntriesSortedByPersonName()
        {
            // Creating a List of cintact to sort by person Name
            //sort the element of a sequence in asc order according to key
            // to list containelement from to th input sequence
            List<Contact> sortedByPersonName = this.contactList.OrderBy(obj => (obj.fistName + obj.lastName)).ToList();
            // Displaying the elements of List

            foreach (Contact contact in sortedByPersonName)
            {
                // displaying the number
                // of elements of List<T>
                Console.WriteLine("-----------");
                Console.WriteLine("FirstName: " + contact.fistName + "\tLastName: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address + "\tCity: " + contact.city + "\tState: " + contact.state);
                Console.WriteLine("Zip: " + contact.zip + "\tPhoneNumber: " + contact.phoneNumber + "\tEmail: " + contact.email);
                Console.WriteLine("-----------");
            }
        }
        public void WriteContactsIntoFile(List<Contact> contacts)
        {
            String path = @"C:\Users\hp\Desktop\BriLabz\AddressBookSystem\AddressBookSystem\AddressBookSystem\TextFile1.txt";

            StreamWriter stream = new StreamWriter(path);
            foreach (Contact contact in contactList)
            {
               // Console.WriteLine("Name: " + contact.fistName + "\t");
               // Console.WriteLine("LastName: " + contact.lastName + "\t");
               // Console.WriteLine("State: " + contact.state + "\t");
                stream.Write("Name: " + contact.fistName + "\t");
                stream.Write("LastName: " + contact.lastName + "\t");
                stream.Write("State: " + contact.state + "\t");
               
                stream.WriteLine("\n");
            }
            stream.Close();
        
            ReadContactsFromFile(contacts);
        }

        public void ReadContactsFromFile(List<Contact> contacts)
        {
            String path = @"C:\Users\hp\Desktop\BriLabz\AddressBookSystem\AddressBookSystem\AddressBookSystem\TextFile1.txt";

            StreamReader stream = new StreamReader(path);

            Console.WriteLine(stream.ReadToEnd());
            stream.Close();
        }
    }
}