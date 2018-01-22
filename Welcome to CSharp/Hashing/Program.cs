using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoGraphyInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            const string orginalMessage = "Orginal Message to Hash";
            const string orginalMessage2 = "This is Another Message to Hash";

            Console.WriteLine("Output after Hashing");

            Console.WriteLine( "Orginale Message 1:" + orginalMessage);
            Console.WriteLine("Orginale Message 2:" + orginalMessage2);

            Console.WriteLine("MD5");
            Console.WriteLine("Orginale Message 1:" + Convert.ToBase64String(HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(orginalMessage))));
            Console.WriteLine("Orginale Message 2:" + Convert.ToBase64String(HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(orginalMessage2))));

            Console.WriteLine("SHA1");
            Console.WriteLine("Orginale Message 1:" + Convert.ToBase64String(HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(orginalMessage))));
            Console.WriteLine("Orginale Message 2:" + Convert.ToBase64String(HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(orginalMessage2))));

            Console.WriteLine("SHA256");
            Console.WriteLine("Orginale Message 1:" + Convert.ToBase64String(HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(orginalMessage))));
            Console.WriteLine("Orginale Message 2:" + Convert.ToBase64String(HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(orginalMessage2))));

            Console.WriteLine("SHA512");
            Console.WriteLine("Orginale Message 1:" + Convert.ToBase64String(HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(orginalMessage))));
            Console.WriteLine("Orginale Message 2:" + Convert.ToBase64String(HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(orginalMessage2))));

            Console.ReadLine();
        }
    }
}
