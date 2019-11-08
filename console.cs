using System;
using contacts;
namespace console
{
    public listMenu(){
        Console.WriteLine("enter your option 1.add\n 2.delete 3.edit 4.search conatct 5.Get all contact");
        int  selection = int.Parse(Console.ReadLine());
        return selection;
    } 
    
    public  getContact(Contact contact){

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
    public void delContact(){

          Console.WriteLine("enter the name to be deleted") ;
          contactName = Console.ReadLine();
          return  contactName ;
    }

    public void editName(){
            Console.WriteLine("enter the name whose number to be edited ") ;
            contactName = Console.ReadLine();
            index = contact.IndexOf("contactName"); 
            Console.WriteLine("enter the new name ") ;
            newName = Console.ReadLine();
            return;
    }      

}