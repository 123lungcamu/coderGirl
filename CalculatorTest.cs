using CalculatorApp1;

namespace CalculatorTester
{
    public class CalculatorTester
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();

            CalculatorApp app = new CalculatorApp();

            int w = 4;
            app.Adding(w);

            double y = 6,7;
            double x = 8.8;
            app.Subtracting(y, x);

            double q = 8.4;
            double r = 2.0;
            app.Dividing(q, r);

            int z = 4;
            app.Multiply(z);
        }

    }
}