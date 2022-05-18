using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using BAMTS.Internal;

namespace Tester
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
    }
}
