using Tyuiu.RaushKN.Sprint7.Project.V9.Lib;

namespace Tyuiu.RaushKN.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidFilmsData()
        {
            string path = $@"C:\Users\rausc\source\repos\Tyuiu.RaushKN.Sprint7\Tyuiu.RaushKN.Sprint7.Project.V9\bin\Debug\FilmsData.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }


        [TestMethod]
        public void ValidGenreCount()
        {
            DataService ds = new DataService();

            int[] wait = { 2, 1, 1, 2, 2, 0, 3 };
            int[] result = ds.GetGenreStatistics();
            CollectionAssert.Equals(wait, result);
        }
    }
}