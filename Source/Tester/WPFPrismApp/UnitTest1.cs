using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using BAMTS.Internal;

namespace Tester.WPFPrismApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IDataAccessor>();  // Mock生成
            IDataAccessor port = mock.Object;  // IDataAccessorを継承したダミークラスを取得
        }
        [TestMethod]
        public void UCGCEmployeeListViewModel_()
        {
            var mockMS = new Mock<IMessageService>();  // Mock生成
            var mockDA = new Mock<IDataAccessor>();  // Mock生成
            var vm = new UCGCEmployeeListViewModel(mockDA.Object, mockMS.Object);
        }
    }
}
