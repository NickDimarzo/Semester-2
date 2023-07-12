namespace Lab7Testing
{

    public class MathTests
    {
        private BasicMath math;
        private double num1;
        private double num2;

        [SetUp]
        public void Setup()
        {
            math = new BasicMath();

        }

        [TearDown]
        public void Teardown()
        {
            math = null;
        }

        [Test]
        public void AddTest()
        {
            num1 = 1.8347;
            num2 = 2.8273;

            double num3 = math.Add(num1, num2);

            Assert.AreEqual(num1 + num2, num3);
        }

        [Test]
        public void SubtractTest()
        {
            num1 = 5.43;
            num2 = 2.823;

            double num3 = math.Subtract(num1, num2);

            Assert.AreEqual(num1 - num2, num3);
        }

        [Test]
        public void DivideTest()
        {
            num1 = 10.27;
            num2 = 2.982;

            double num3 = math.Divide(num1, num2);

            Assert.AreEqual(num1 / num2, num3);
        }

        [Test]
        public void MultiplyTest()
        {
            num1 = 10.7;
            num2 = 2.6;

            double num3 = math.Multiply(num1, num2);

            Assert.AreEqual(num1 * num2, num3);
        }
    }
}