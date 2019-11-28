using System.Collections.Generic;
using kavyaphonebook;
using System;

public class PhoneBook
     {  
      List<Contact> contacts = new List<Contact>();
      Contact contact = new Contact();
      JsonHandler jsonhandler = new JsonHandler();

      consoleHandler handler = new consoleHandler();
        

              public  void AddContact(Contact ContactDetails)
              {
               contacts.Add(ContactDetails);
               return;
               
              }

              public List<Contact> display()
              {
                return contacts;
              }

              public   void DeleteContact(Contact DeleteName)
             {
              contacts.Remove(DeleteName);       
          
             }

             public void addfile()
            {
              jsonhandler.addfile(contacts);
            }



           public void EditContact() => handler.editName(contacts);

           public void contactList(){
               foreach ( Contact person in contacts){
             Console.WriteLine("Name :" +person.FirstName +person.LastName  +"PhoneNumber :"+person.PhoneNumber +"\nEmail Id:" +person.mailid);
           }

       }
    
    
    
    
    
    
    
    
    // public void searchContact()
    //{
    // Console.WriteLine("enter the name to search ") ;
    // string name = Console.ReadLine();
    // contact.find(name);
    //  Console.WriteLine("the contact No of {0} is {1}",name,Value) ;

    //}

    

    }
