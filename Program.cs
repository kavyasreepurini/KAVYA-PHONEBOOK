 using System;
//using contacts;
using System.Collections.Generic;
//using console;

namespace kavyaphonebook
{
    class Program
    {
         consoleHandler handler = new consoleHandler();
        public void Main(string[] args)
        {
             PhoneBook phonebook = new PhoneBook();
             handler.listMenu(int selection);
             
            
             switch (selection)
             {
             case 1: phonebook.AddContact();
                     break;
             case 2: phonebook.DeleteContact();
                       break;
             case 3: phonebook.EditContact();
                       break;
            // case 5: phonebook.getContacts();
                      // break;
             //case 4: phonebook.searchContact();
                      // break;

             }         
       }
    }   

    
}


