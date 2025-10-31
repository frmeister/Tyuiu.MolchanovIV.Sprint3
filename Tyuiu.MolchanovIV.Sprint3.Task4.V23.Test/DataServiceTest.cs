using Tyuiu.MolchanovIV.Sprint3.Task4.V23.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(-5, 5);
            Assert.AreEqual(1.0, res);  
        }
    }
}
