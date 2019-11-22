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
             SelectionSwitch selectionSwitch = new SelectionSwitch();
         
           int  Option =  handler.listMenu();
           selectionSwitch.SelectionMethod(Option);
           //phonebook.addfile();
                     
       }
    }   

    
}


