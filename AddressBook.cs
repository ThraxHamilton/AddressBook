using System;
using System.Collections.Generic;

namespace AddressBook {
    public class AddressBook {
        Dictionary<string, Contact> AddyBook = new Dictionary<string, Contact> ();
       
            public void AddContact (Contact contact) {

                AddyBook.Add (contact.Email, contact);
            }
            public Contact GetByEmail (string email) {
                return AddyBook[email];
            }
       
        
    }
}