using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_CSharp
{
    class DelegateDemo
    {
        public delegate void DelegateMethodHandler(int Hours, Worktype worktype);
        static void Main()
        {
            DelegateMethodHandler del1 = new DelegateMethodHandler(DelegateMethod1);
            DelegateMethodHandler del2 = new DelegateMethodHandler(DelegateMethod2);

            Dowork(del1);
            Dowork(del2);
            Console.ReadLine();

        }


        public static void Dowork(DelegateMethodHandler dels)
        {
            dels(5, Worktype.Doctors);
        }


        public static void DelegateMethod1(int hrs, Worktype wrktyp)
        {
            Console.WriteLine("Called DelegateMethod1 :" + wrktyp.ToString());
        }

        public static void DelegateMethod2(int hrs, Worktype wrktyp)
        {
            Console.WriteLine("Called DelegateMethod2 :" + wrktyp.ToString());
        }
        public enum Worktype
    {
        Engineers,
        Doctors,
        ITProfessionals
        
    };

    }

}
