using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Welcome_to_CSharp
{
    public class Customer
    {

        public Customer(string custName)
        {
            this.Name = custName;
        }
        public string Name { get; set; }


        public void DisplayCustomerName()
        {
            Console.WriteLine("Customer Name {0}", this.Name);
        }

    }

    public class Products
    {

        public Products(string prodName)
        {
            this.Name = prodName;
        }
        public string Name { get; set; }


        public void DisplayProductName()
        {
            Console.WriteLine("Product Name {0}", this.Name);
        }

    }


    public class GenericDemo<T> 
        //where  T:  struct, Customer                                 
    {

        public void Display<t>(T obj) 
        {
            var typevar = obj.ToString();       

            Console.WriteLine(" Given Type is {0}", typevar);
        }

        public void Display(string str)
        {
            Console.WriteLine(" Method without Generic {0}", str);
        }


        public T getGenericObject<T>(T obj) 
        {
            
            return obj;
        }
    }

  

}
