using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Collaborator
    {
        private string firstName;
        private string lastName;
        private string state;
        private string location;
        private string email;
        private string mobileNo;
        private int distance;
        private string instagram;

        public Collaborator(string Firstname, string Lastname, string State, string Location, string Email, string Mobileno, string Distance, string Instagram)
        {
            firstName = Firstname;
            lastName = Lastname;
            state = State;
            location = Location;
            email = Email;
            mobileNo = Mobileno;
            distance = int.Parse(Distance);
            instagram = Instagram;
        }
    }
}
