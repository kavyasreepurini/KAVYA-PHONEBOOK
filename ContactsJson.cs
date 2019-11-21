//using System.Text.Json;
//using System.Text.Json.Serialization;

//string filepath = @"C:\test.txt";
//using (StreamWriter writer = new StreamWriter(filepath))
//{
// writer.WriteLine("some text");
//}
using Newtonsoft.Json;
using System;
using kavyaphonebook;
using System.IO;
using System.Collections.Generic;
class ContactsJson{
//List<Contact> contacts = new List<Contact>();


public void addfile(List<Contact> contacts)
{
string contactsJson = JsonConvert.SerializeObject(contacts, Formatting.Indented);



       StreamWriter writer = new StreamWriter(@"/Users/kavyasree/Documents/kavyaPhonebook/KAVYA-PHONEBOOK/phonebook.json");
       Console.WriteLine(contactsJson);
       // To write a line in buffer 
       writer.Write(contactsJson);
      // To write in output stream 
       writer.Flush(); 
       // To close the stream 
       writer.Close();  
       Console.ReadKey();
}
           
                
           

}
           