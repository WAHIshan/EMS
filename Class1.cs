using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public string NIC { get; set; }
        public string OrganiztionName { get; set; }
        public string OrganizationType { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }
        public string Town { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
