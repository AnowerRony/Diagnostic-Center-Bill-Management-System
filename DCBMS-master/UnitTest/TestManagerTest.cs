using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiagnosticC.B.M.SystemV2._29.BusinessLoginLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using Test = DiagnosticC.B.M.SystemV2._29.DataAccessLayer.Model.Test;

namespace DiagnosticC.B.M.SystemV2._29.UnitTest
{
    [TestClass]
    public class TestManagerTest
    {
        TestManager aTestManager = new TestManager();

        [TestMethod]
        public void SaveTest()
        {
            Test aTest = new Test
            {
                TestName = "X-ray",
                TestType = "X-ray",
                Fee = 500,
                TestTypeId = 16
            };
            Assert.AreEqual("Test Saved : ",aTestManager.SaveTest(aTest));
        }
    }
}