using System;
using System.Collections.Generic;
using phonebook2;
using console;
namespace contacts
{
    class Contact
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public double PhoneNumber {get;set;}
        public string mailid {get;set;}
    }  
      List<Contact> contacts = new List<Contact>();

     class PhoneBook
     {  
        Contact contact = new Contact();

     public  void AddContact()
        { 
            getContact(Contact contact);
            contacts.Add(contact);
        }

    public   void DeleteContact()
       { 
           delContact();       
          contacts.Remove(contactName);
       }

     public  void EditContact()
       {
            contact.Insert(index, newName);
            
       }
      // public void searchContact()
        //{
           // Console.WriteLine("enter the name to search ") ;
           // string name = Console.ReadLine();
           // contact.find(name);
           //  Console.WriteLine("the contact No of {0} is {1}",name,Value) ;

       //}
    
     public void getContacts()
     {
       foreach ( var person in contacts)
      {
       Console.WriteLine("Name : "+person.firstName+" "+person.lastName+",PhoneNumber :"+person.phoneNumber+", Email Id:"+person.emailId); );
      }

     }

    }
}