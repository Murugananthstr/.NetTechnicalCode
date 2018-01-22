using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoGraphyInDotNet 
{
    public class HashData
    {
        public static byte[] ComputeHashSha1(byte[] toBeHashed)
        {
          
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }

        }

        public static byte[] ComputeHashSha256(byte[] toBeHashed)
        {

            using (var sha1 = SHA256.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }

        }

        public static byte[] ComputeHashSha512(byte[] toBeHashed)
        {

            using (var sha1 = SHA512.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }

        }

        public static byte[] ComputeHashMd5(byte[] toBeHashed)
        {

            using (var sha1 = MD5.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }

        }


    }
}
