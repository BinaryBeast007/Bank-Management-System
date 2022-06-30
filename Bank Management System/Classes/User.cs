using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.Classes
{
    internal abstract class User
    {
        private string name;
        private string gender;
        private string address;
        private string dob;
        private string nationality;
        private string email;
        private string mobileNumber;
        private string nidNo;

        public User() { }
        public User(string name, string gender, string address, string dob, string nationality, string email, string mobileNumber, string nidNo)
        {
            this.name = name;   
            this.gender = gender;
            this.address = address;
            this.dob = dob;
            this.nationality = nationality;
            this.email = email;
            this.mobileNumber = mobileNumber;
            this.nidNo = nidNo;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Dob { get { return dob; } set { dob = value; } }
        public string Nationality { get { return nationality; } set { nationality = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string MobileNumber { get { return mobileNumber; } set { mobileNumber = value; } }
        public string NidNo { get { return nidNo; } set { nidNo = value; } }
    }
}
