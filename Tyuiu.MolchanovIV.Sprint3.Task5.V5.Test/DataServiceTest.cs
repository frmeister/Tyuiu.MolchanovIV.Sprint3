using Tyuiu.MolchanovIV.Sprint3.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            Assert.AreEqual(1, res);
        }
    }
}
