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
             //PhoneBook phonebook = new PhoneBook();
             
             
           int  Option =  handler.listMenu(int selection);
             
             
             SelectionSwitch selectionSwitch = new SelectionSwitch();
             selectionSwitch.SelectionMethod(Option);
             
                     
       }
    }   

    
}


