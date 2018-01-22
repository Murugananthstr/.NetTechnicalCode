using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCapCSharpFundamentals
{
    public class Customer
    {
       public string CustomerName { get; set; }

        private string _customeraddress;

        public string CustomerAddress {
            get
            {
                return _customeraddress;
            }
            set {

                if (_customeraddress != value)
                {
                    string oldValue = _customeraddress;
                    _customeraddress = value;

                    if (NameChangeDelegatePointer != null)
                    {

                        AddressChangedEventArgs args = new AddressChangedEventArgs();
                        args.CustomerAddressOldValue = oldValue;
                        args.CustomerAddressNewValue = value;
                        NameChangeDelegatePointer(this, args);
                    }
                }
            }
        }

        public event NameChangedDelegateReference NameChangeDelegatePointer;
       
    }
}
