using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
   public class Person
    {
       public string fname;
       public string lname;
       public string phoneNum;
       public string email;
       public string address;
       public string bloodType;
       public string antigen;
      
     

        public Person(string firstname, string lastname, string phonenumber,string emailad,
        string homeaddress, string thebloodType, string theantigen)
        {
            this.fname = firstname;
            this.lname = lastname;
            this.phoneNum = phonenumber;
            this.address = homeaddress;
            this.email = emailad;
            this.bloodType = thebloodType;
            this.antigen = theantigen;
        }

        public Person()
        {
            // TODO: Complete member initialization
        }

    

        



    }

   
}
