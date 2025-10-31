using Tyuiu.MolchanovIV.Sprint3.Task7.V1.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(res, new double[] { -12.18, 16.03, 18.87, 4.96, -9.99, -2, 2.16, -7.54, -22.76, -20.45, 7.77 } );    
        }
    }
}
