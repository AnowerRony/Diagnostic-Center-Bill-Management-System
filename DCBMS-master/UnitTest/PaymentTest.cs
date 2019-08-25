using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiagnosticC.B.M.SystemV2._29.BusinessLoginLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiagnosticC.B.M.SystemV2._29.UnitTest
{
    [TestClass]
    public class PaymentTest
    {
        PaymentManager aPaymentManager = new PaymentManager();

        [TestMethod]
        public void GetDueTest()
        {
            Assert.AreEqual(null,aPaymentManager.GetDue("103","01982610143"));
        }

        [TestMethod]
        public void MakePaymentTest()
        {
            Assert.AreEqual("Payment Successful",aPaymentManager.MakePayment(103));
        }
    }
}