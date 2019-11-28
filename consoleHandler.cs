 using System;
using kavyaphonebook;
using System.Collections.Generic; 


    public class consoleHandler{
    public int listMenu( ){
         Console.WriteLine("enter your option 1.add\n 2.delete 3.edit 4.search conatct 5.Get all contact");
         int selection = int.Parse(Console.ReadLine());
         return selection;
    } 
    
    public Contact getContact(Contact contact){

          Console.WriteLine("enter the firstname ") ;
          contact.FirstName = Console.ReadLine();

          Console.WriteLine("enter the lastname ") ;
          contact.LastName = Console.ReadLine();

          Console.WriteLine("enter the number");
          contact.PhoneNumber = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("enter the mailid");
          contact.mailid = Console.ReadLine();

          return contact;
    }
    public Contact delContact(List<Contact> contacts){
       // MyClass item = MyList.Find(item => item.name == "foo");

          Console.WriteLine("enter the name to be deleted") ;
          string Name = Console.ReadLine();
          Contact contactName =  contacts.Find(item => item.FirstName == Name);
        // contacts.Remove(contactName);
          return contactName;
          
    }

    public void editName( List<Contact> contacts){
           // Console.WriteLine("enter the name whose number to be edited ") ;
          // string contactName = Console.ReadLine();
           // int index = contact.IndexOf("contactName"); 
           // Console.WriteLine("enter the new name ") ;
           //string newName = Console.ReadLine();
           // return ;
           Console.WriteLine("Enter the FirstName to be edited");
           string Name = Console.ReadLine();
           Console.WriteLine("Enter the newName ");
           string newName = Console.ReadLine();
           for(int i=0;i<contacts.Count;i++)
        {
             if(contacts[i].FirstName.Contains(Name))
               contacts[i].FirstName = newName;
               break;
        }
             return; 
    }      

    
 }