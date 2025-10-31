using Tyuiu.MolchanovIV.Sprint3.Task2.V6.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.GetMultiplySeries(0.25, 1, 10);
            Assert.AreEqual(1, res);
        }
    }
}
