 using System;
using contacts;
using System.Collections.Generic;
using console;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
             PhoneBook phonebook = new PhoneBook();
             listMenu();
             
            
             switch (selection)
             {
             case 1: phonebook.AddContact();
                     break;
             case 2: phonebook.DeleteContact();
                       break;
             case 3: phonebook.EditContact();
                       break;
             case 5: phonebook.getContacts();
                       break;
             case 4: phonebook.searchContact();
                       break;

             }         
       }
    }   

    
}
© 2019 GitHub, Inc.

