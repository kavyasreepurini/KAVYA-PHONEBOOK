 using System;
using System.Collections.Generic;


namespace Kavya.Phonebook
{
    class Program
    {
        
        public static void Main(string[] args)
        {
           ConsoleHandler handler = new ConsoleHandler();
           PhoneBook phonebook = new PhoneBook();
           Contact contact = new Contact();
           
         
           int  Option =  handler.selectMenutItem();
           callSwitch(Option);
           phonebook.PrintContactList();
           phonebook.addfile();

         void callSwitch(int option)
           {
                switch (Option)
              {
                 case 1:
                  Contact ContactToAdd = handler.getContact( contact);
                  phonebook.AddContact(ContactToAdd);
                  break;

                case 2:
                 Contact ContactToDelete = handler.deleteContact(phonebook.display());
                 phonebook.DeleteContact(ContactToDelete);
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


