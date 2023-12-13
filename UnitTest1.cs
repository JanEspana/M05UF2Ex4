using Areas;
namespace ExerciciAreasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 3, expected = x * x;
            Assert.AreEqual(expected, Ex23.Square(x));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 3, y = 4, expected = x * y;
            Assert.AreEqual(expected, Ex23.Rectangle(x, y));
        }
        [TestMethod]
        public void TestMethod3()
        {
            double x = 3, expected = x * x * Math.PI;
            Assert.AreEqual(expected, Ex23.Circle(x));
        }
        [TestMethod]
        public void TestMethod4()
        {
            double x = 3, y = 2, expected = x * 5 * y / 2;
            Assert.AreEqual(expected, Ex23.Pentagon(x, y));
        }
    }
}