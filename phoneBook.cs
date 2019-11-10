using System.Collections.Generic;
using kavyaphonebook;

public class PhoneBook
     {  
         List<Contact> contacts = new List<Contact>();
        Contact contact = new Contact();
        consoleHandler handler = new consoleHandler();

     public  void AddContact()
        { 
           handler.getContact(contact);
            contacts.Add(contact);
        }

    public   void DeleteContact()
       {
         handler.delContact( (List<Contact> contacts);
         contacts.Remove(contactName);       
          
       }

    public void EditContact() => handler.editName(List <Contact> contacts);
    // public void searchContact()
    //{
    // Console.WriteLine("enter the name to search ") ;
    // string name = Console.ReadLine();
    // contact.find(name);
    //  Console.WriteLine("the contact No of {0} is {1}",name,Value) ;

    //}

    //public void getContacts()
     //{
      // foreach ( var person in contacts)

    

     //}

    }
