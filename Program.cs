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
           
         
           int  option =  handler.selectMenutItem();
           actOnSelectMenu(option);
           phonebook.PrintContactList();
           phonebook.addfile();

         void actOnSelectMenu(int option)
           {
                switch (option)
              {
                 case 1:
                  Contact contactToAdd = handler.getContact( contact);
                  phonebook.AddContact(contactToAdd);
                  break;

                case 2:
                 Contact contactToDelete = handler.deleteContact(phonebook.display());
                 phonebook.DeleteContact(contactToDelete);
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


