using System.Collections.Generic;
using kavyaphonebook;
using System;

public class PhoneBook
     {  
         List<Contact> contacts = new List<Contact>();
        
        consoleHandler handler = new consoleHandler();
        Contact contact = new Contact();
        ContactsJson contactsJson = new ContactsJson();

     public  void AddContact()
        { 
           
            
            contacts.Add(handler.getContact(contact));
            contactsJson.addfile(contacts);

             


        }

     public   void DeleteContact()
       {
          Contact DeleteName = handler.delContact(contacts);
          contacts.Remove(DeleteName);       
          
       }

     //public void addfile()
       //{
         //contactsJson.addfile(contacts);
       //}



    public void EditContact() => handler.editName(contacts);
    
    
    
    
    
    
    
    
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
