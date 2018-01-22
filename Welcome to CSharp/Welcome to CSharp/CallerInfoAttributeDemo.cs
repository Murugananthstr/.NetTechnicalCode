using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Welcome_to_CSharp
{
    public class CallerInfoAttributeDemo
    {
        public string WhoCalledMe([CallerMemberName] string callingMember =null)
        {

            return "I was called from member : " + callingMember;

        }

        public string WhereIam([CallerFilePath] string callerFilePath=null)
        {
            return "I am put up from :" + callerFilePath;
        } 
    }
}
