using System.Collections.Generic;

namespace AddressBook {
    public class AddressBook {
        Dictionary<string, string> AddyBook = new Dictionary<string, string> ();
        public void AddContact (Contact contact){
            
            AddyBook.Add(contact.FirstName, contact.Email);
            
        }

    }
}