using Microsoft.VisualStudio.TestTools.UnitTesting;
using KvadratickaRovnice;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow(2, -11, 14, 2, 3.5)]
        public void TestMethod1(double a, double b, double c, double x1, double x2)
        {
            //Arrange

            //Act
            Koren koren = new Koren(Koren.Equation(a,b,c));

            //Assert
            Assert.AreEqual(x2, koren.x1);
            Assert.AreEqual(x1, koren.x2);
        }
    }
}
