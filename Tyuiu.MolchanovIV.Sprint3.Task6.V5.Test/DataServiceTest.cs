using Tyuiu.MolchanovIV.Sprint3.Task6.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(15, 22);
            Assert.AreEqual(242, res);
        }
    }
}
