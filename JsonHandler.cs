
using Newtonsoft.Json;
using System;
using Kavya.Phonebook;
using System.IO;
using System.Collections.Generic;


class JsonHandler{

  public void exportToFile(List<Contact> contacts)
   {


     string contactsJson = JsonConvert.SerializeObject(contacts, Formatting.Indented);

     StreamWriter writer = new StreamWriter(@"/Users/kavyasree/Documents/kavyaPhonebook/KAVYA-PHONEBOOK/phonebook.json");
      
         writer.Write(contactsJson);
         writer.Flush(); 
         writer.Close();  
       
   }          
       

           
}                
           


           