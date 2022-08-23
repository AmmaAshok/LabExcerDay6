using RestClassLib;
using RestSharp;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;

namespace RestClassTest
{
    [TestClass]
    public class UnitTest1

    {   

         private TestContext testcontextInstance;

        public TestContext TestContext

       {
          get{ return testcontextInstance; }
          set{ testcontextInstance = value; }
         }

        [TestMethod]
        public void TestMethod1()
        {
            string r =APIClassLib.GetMethod();
            TestContext.WriteLine("Get Method Output \n\n\n" +r);
            Assert.AreEqual("hi","hello","String not matched");
            
        }

        
        [TestMethod]
        public void TestMethod2()
        {
            string r =APIClassLib.PostMethod();
            TestContext.WriteLine("Post Method Output \n\n\n" +r);
            Assert.AreEqual("hi","hello","String not matched");
            
        }

        [TestMethod]
        public void TestMethod3()
        {
            string r =APIClassLib.PutMethod();
            TestContext.WriteLine("Put Method Output \n\n\n" +r);
            Assert.AreEqual("hi","hello","String not matched");
            
        }
    }
}
