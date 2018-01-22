using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapCSharpFundamentals
{
    //public delegate void NameChangedDelegateReference(string oldNameValue, string newNameValue); Only for Delegates

    public delegate void NameChangedDelegateReference(object sender, AddressChangedEventArgs args);



}
