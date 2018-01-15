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
         

            cus.NameChangeDelegatePointer = new NameChangedDelegateReference(OnNameChange);
            cus.CustomerAddress = "Muruganantham";


            Console.WriteLine("Invoked Customer Method");
            Console.ReadLine();
                
           }

        private static void OnNameChange(string oldNameValue, string newNameValue)
        {
            Console.WriteLine("{0} is now changed to {1}",oldNameValue,newNameValue);
        }
    }
}
