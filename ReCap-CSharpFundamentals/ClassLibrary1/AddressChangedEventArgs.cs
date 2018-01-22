using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapCSharpFundamentals
{
   public class AddressChangedEventArgs : EventArgs
    {
        public string CustomerAddressOldValue { get; set; }
        public string CustomerAddressNewValue { get; set; }
    }
}
