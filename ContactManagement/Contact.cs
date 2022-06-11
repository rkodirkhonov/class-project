using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement
{
    internal class ContactManagement
    {
        private String name;
        private String phoneNo;
        private String birthDay;
        private String city;

        public ContactManagement(string name, string phoneNo, string birthDay, string city)
        {
            this.name = name;
            this.phoneNo = phoneNo;
            this.birthDay = birthDay;
            this.city = city;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String PhoneNo
        {
            get { return this.phoneNo; }
            set { this.phoneNo = value; }
        }

        public String BirthDay
        {
            get { return this.birthDay;}
            set { this.birthDay = value; }
        }

        public String City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.name + ", " + this.phoneNo + ", " + this.birthDay + ", " + this.city);
            return sb.ToString();
        }
    }
}