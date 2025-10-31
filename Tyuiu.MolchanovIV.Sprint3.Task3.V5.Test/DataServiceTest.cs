using Tyuiu.MolchanovIV.Sprint3.Task3.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.ReplaceCharInString("fifa al fall", 'a', '*');
            Assert.AreEqual("fif* *l f*ll", res);
        }
    }
}
