using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public static int InstanceCount { get; set; }


        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public int CustomerID { get; private set; }

        public string FullName
        {
            get
            {
                if(String.IsNullOrWhiteSpace(FirstName))
                { 
                        return LastName;
                }else if (String.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }else
                {
                    return LastName + ", " + FirstName;
                }

            }


        }

        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
