using Tyuiu.MolchanovIV.Sprint3.Task0.V22.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression ()
        {
            DataService ds = new DataService ();
            double res = ds.GetMultiplySeries(0.25, 1, 8);
            Assert.AreEqual(55217.446, Math.Round(res, 3));
        }
    }
}
