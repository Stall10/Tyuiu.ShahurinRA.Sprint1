using Tyuiu.ShahurinRA.Sprint1.Task0.V28.Lib;

namespace Tyuiu.ShahurinRA.Sprint1.Task0.V28.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(0);
            Assert.AreEqual(2, res);
        }
    }
}
