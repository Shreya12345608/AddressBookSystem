using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    /// <summary>
    /// property of AddressBook
    /// </summary>
    class Contact
    {

        /// <summary>
        /// property of FirstName LastName etc
        ///  get and set method
        /// </summary>
        public string fistName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }
    }
}
