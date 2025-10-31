using Tyuiu.MolchanovIV.Sprint3.Task1.V27.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(0.1, 1, 2);
            Assert.AreEqual(1.0, res);

        }
    }
}
