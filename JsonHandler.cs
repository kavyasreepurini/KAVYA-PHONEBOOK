
using Newtonsoft.Json;
using System;
using kavyaphonebook;
using System.IO;
using System.Collections.Generic;
class JsonHandler{



public void addfile(List<Contact> contacts)
{


string contactsJson = JsonConvert.SerializeObject(contacts, Formatting.Indented);



       StreamWriter writer = new StreamWriter(@"/Users/kavyasree/Documents/kavyaPhonebook/KAVYA-PHONEBOOK/phonebook.json");
      
         writer.Write(contactsJson);
         writer.Flush(); 
          //Console.WriteLine(contactsJson);
         // To write a line in buffer 
        //File.WriteAllText(@"/Users/kavyasree/Documents/kavyaPhonebook/KAVYA-PHONEBOOK/phonebook.json",contactsJson);
        // To write in output stream 
         
       // To close the stream 
       //writer.Close();  
       
}
           
                
           

}
           