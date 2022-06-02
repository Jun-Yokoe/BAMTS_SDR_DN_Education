using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using XamarinPrismApp.ViewModels;
using Prism.Navigation;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var moq = new Moq.Mock<INavigationService>();
            var mvm = new MainPageViewModel(moq.Object);
            var res = mvm.EmployeeList;
            Assert.AreEqual(res.Count, 7);
        }
    }
}
