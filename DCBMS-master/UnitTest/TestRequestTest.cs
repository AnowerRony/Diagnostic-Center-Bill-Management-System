using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiagnosticC.B.M.SystemV2._29.BusinessLoginLayer;
using DiagnosticC.B.M.SystemV2._29.DataAccessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiagnosticC.B.M.SystemV2._29.UnitTest
{
    [TestClass]
    public class TestRequestTest
    {
        TestRequestManager aTestRequestManager = new TestRequestManager();

        [TestMethod]
        public void SavePatientTest()
        {
            Patient aPatient = new Patient
            {
                Name = "ABC",
                DateOfBirth = "2000-02-26",
                MobileNo = "01982610143",
                BillAmount = 1000,
                PaymentStatus = 1
            };
            Assert.AreEqual("Patient Information saved.",aTestRequestManager.SavePatient(aPatient));
        }

        public void SaveTestRequest()
        {
            TestRequest aTestRequest = new TestRequest
            {
                PatientId = 103,
                TestId = 1029,
                EntryDate = DateTime.Now.ToString("yy-MM-dd")
            };
            Assert.AreEqual("Test Request Saved",aTestRequestManager.SaveTestRequest(aTestRequest));
        }
    }
}