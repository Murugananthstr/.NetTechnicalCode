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
            cus.CustomerAddress = "No 36, Vinayagar Kovil St, The Nilgiris";
         

            cus.NameChangeDelegatePointer += OnNameChange;//oldway of declration
            cus.NameChangeDelegatePointer += OnNameChange1;//Multicast Delegate
            cus.CustomerAddress = "No 14, Jayalakshimi Appartment, Chennai 73";

            Console.WriteLine("Invoked Customer Method");
          

            Worker worker = new Worker(new WorkPerformedEventArgs(5, WorkType.GenerateReport));
          //  worker.WorkPerfomed += worker.OnWorkPerformed;

            
            var delRes = worker.OnWorkPerformed;


            Console.ReadLine();
           }

        
        private static void OnNameChange(object sender, AddressChangedEventArgs args)
        {
            Console.WriteLine("{0} is now changed to {1}", args.CustomerAddressOldValue, args.CustomerAddressNewValue);
        }

        private static void OnNameChange1(object sender, AddressChangedEventArgs args)
        {
            Console.WriteLine("Old Value of Customer Address : {0}", args.CustomerAddressOldValue);
            Console.WriteLine("New Value of Customer Address : {0}", args.CustomerAddressNewValue);
        }

        //private static void OnNameChange1(string oldNameValue, string newNameValue)
        //{
        //    Console.WriteLine("Old Value of Customer Address : {0}", oldNameValue);
        //    Console.WriteLine("New Value of Customer Address : {0}", newNameValue);

        //}

        //private static void OnNameChange(string oldNameValue, string newNameValue)
        //{
        //    Console.WriteLine("{0} is now changed to {1}",oldNameValue,newNameValue);
        //}
    }
}
