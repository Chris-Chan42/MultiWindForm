using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindForm
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string? ToString()
        {
            return $"{CustomerID} - {Name} - {PhoneNumber} - {Email}";
        }
    }
}
