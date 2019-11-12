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
             
             SelectionSwitch switchSelection = new SelectionSwitch();
             SelectionSwitch.SelectionMethod(selection);
             
                     
       }
    }   

    
}


