 using System;
using System.Collections.Generic;


namespace kavyaphonebook
{
    class Program
    {
        
        public static void Main(string[] args)
        {
           consoleHandler handler = new consoleHandler();
           PhoneBook phonebook = new PhoneBook();
           Contact contact = new Contact();
           
         
           int  Option =  handler.listMenu();
           callswitch(Option);
           phonebook.contactList();
           phonebook.addfile();

         void callswitch(int option)
           {
                switch (Option)
              {
                 case 1:
                  Contact ContactDetails = handler.getContact( contact);
                  phonebook.AddContact(ContactDetails);
                  break;

                case 2:
                 Contact DeleteName = handler.delContact(phonebook.display());
                 phonebook.DeleteContact(DeleteName);
                 break;

                case 3:
                 phonebook.EditContact();
                 break;
                
                //case 4: phonebook.searchContact();
                //break;
        }

           }
                     
       }
    }   

    
}


