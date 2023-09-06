using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void BeforeTest()
        {
            // WebDriver Initialization 

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // Open the 

        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("I am in test Method1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("I am in Test Method2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("I am in Test Method3");

        }

    }
}