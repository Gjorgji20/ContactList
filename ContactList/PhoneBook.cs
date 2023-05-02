using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; }
        
        public PhoneBook() { }

        public PhoneBook(List<Contact> contacts)
        {
            Contacts = contacts;
        }
        public void addContact(Contact contact)
        {
            if(Contacts.Count > 250) 
            {
                foreach(Contact con in Contacts)
                {
                    if(con.getName().Equals(contact.getName()))
                    {
                        throw new Exception("The name exists");
                    }
                    else
                    {
                        Contacts.Add(con);
                        Console.WriteLine("The contact was added");
                    }    
                }
            }
            else
            {
                throw new Exception("full list");
            }    
        }
    }
}
