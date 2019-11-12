using System;
using kavyaphonebook;
public class SelectionSwitch
{
    PhoneBook phonebook = new PhoneBook();

public void SelectionMethod( int Option){

    switch (Option)
             {
             case 1: phonebook.AddContact();
                     break;
             case 2: phonebook.DeleteContact();
                       break;
             case 3: phonebook.EditContact();
                       break;
            // case 5: phonebook.getContacts();
                       //break;
             //case 4: phonebook.searchContact();
                       //break;
             }
        }
}