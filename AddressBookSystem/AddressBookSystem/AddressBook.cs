using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        // adding items mechanism into generic type
        private List<Contact> contactList;
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
        //method print
        public void print()
        {
            //using foreach loop for calling the variable 
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
            // created object ContacttobeEdited fir conatct and at starting it will be null
            Contact contactToBeEdited = null;

            // foreach loop begin
            // it will run till the
            // last element of the array
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                    contactToBeEdited = contact;
            }
            // if First Name And last name is not match with entered data
            //contactToBeEdited == null
            if (contactToBeEdited == null)
            {
                //Error :No such contact exists
                Console.WriteLine("No such contact exists");
                return;
            }
            //otherwise get the value
            this.editThisContact(contactToBeEdited);
        }
        /* <summary>
            fetch details and edit This Contact
            Class Contact contactToBeEdited 
           </summary>
            <param name="contactToBeEdited"></param>
        */
        public void editThisContact(Contact contactToBeEdited)
        {
            //if true
            while (true)
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
                        return;
                }
            }
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
    }
}
