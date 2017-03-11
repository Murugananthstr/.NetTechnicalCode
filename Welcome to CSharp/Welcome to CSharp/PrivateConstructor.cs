using System;
namespace Welcome_to_CSharp
{
    class PrivateConstructor
    {
        private PrivateConstructor()   { }
        
        public static string getData()
        {
            return "Private Constructor Demo here";
        }
       }
    class Program
    {
        static void Main()
        {
            Console.WriteLine(PrivateConstructor.getData());
            Console.ReadLine();
        }
    }
}
