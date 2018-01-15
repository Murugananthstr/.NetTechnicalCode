using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReCapCSharpFundamentals;

namespace ReCap_CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer();
            cus.CustomerAddress = "Ananth";
         

            cus.NameChangeDelegatePointer = new NameChangedDelegateReference(OnNameChange);//oldway of declration
            cus.NameChangeDelegatePointer += OnNameChange1;//Multicast Delegate
            cus.CustomerAddress = "Ananth1";


            Console.WriteLine("Invoked Customer Method");
            Console.ReadLine();
                
           }
        
        private static void OnNameChange1(string oldNameValue, string newNameValue)
        {
            Console.WriteLine("Old Value of Customer Address : {0}", oldNameValue);
            Console.WriteLine("New Value of Customer Address : {0}", newNameValue);

        }

        private static void OnNameChange(string oldNameValue, string newNameValue)
        {
            Console.WriteLine("{0} is now changed to {1}",oldNameValue,newNameValue);
        }
    }
}
