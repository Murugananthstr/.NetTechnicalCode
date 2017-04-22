using System;
namespace Welcome_to_CSharp
{
    public class Program2
    {
        static void Main()
        {
            Console.WriteLine("Welcome to C#");//to display the output to console/screen

            //Implicit method call to Generic

            var impObj = new GenericDemo<string>();
               impObj.Display("Hello");

            var genObj = new GenericDemo<string>();
           genObj.Display<string>("String to Test");
            var genObj1 = new GenericDemo<int>();
            genObj1.Display<int>(1);

            var custObj1 = new GenericDemo<Customer>();
            var cust = custObj1.getGenericObject(new Customer("Ananth"));
            cust.DisplayCustomerName();
            
            var prodObj1 = new GenericDemo<Products>().getGenericObject(new Products("Dell Laptop"));
            prodObj1.DisplayProductName();
            Console.ReadLine();// to get some input, hence we will be able to see the above out results 
        }
    }
}
