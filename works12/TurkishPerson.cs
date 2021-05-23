using System;
using System.Collections.Generic;
using System.Text;

namespace works12
{
    public class TurkishPerson
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Address;

        public TurkishPerson()
        {

        }
        public TurkishPerson(int id, string firstname, string lastname, string address)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;

        }
        public string Nationality(string shortnationalty)
        {
         return "Türkiye Cumhuriyeti " + shortnationalty;



        }


    }
}
