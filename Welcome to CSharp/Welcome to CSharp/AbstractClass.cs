using System;
using System.Collections.Generic;

namespace Welcome_to_CSharp
{

    public abstract class BaseClassEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public List<string> listvar { get; set; }

        public string FullName ()
        {
            return this.FirstName + " " + this.SecondName;
        }

        public abstract int GetSalaray();
        
    }


    public class FullTimeEmployee : BaseClassEmployee
    {
        public override int GetSalaray()
        {
            return 100000;
        }
    }

    public class PartTimeEmployee : BaseClassEmployee
    {
        public override int GetSalaray()
        {
            return 20000;
        }
    }

    
   public class Program
    {
        public static void Main()
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.FirstName = "Muruganantham";
            ft.SecondName = "D";
            Console.WriteLine(ft.FullName());
            Console.WriteLine(ft.GetSalaray());

            BaseClassEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Muruganantham";
            pte.SecondName = "D";
            Console.WriteLine(pte.FullName());
            Console.WriteLine(pte.GetSalaray());
            Console.ReadLine();

        }
    }

}
