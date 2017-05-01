using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Welcome_to_CSharp;
using System.Diagnostics;

namespace Welcome_to_CSharp.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void WhereIamTest()
        {
            var obj = new CallerInfoAttributeDemo();
            Debug.WriteLine(obj.WhereIam());
        }
    }
}

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new CallerInfoAttributeDemo();
            Debug.WriteLine(obj.WhoCalledMe());
            
            
        }
    }
}
