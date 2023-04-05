using net_calculator_tester;


namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1.5f, 3.1f)]
        public void AddTest(float num1, float num2)
        {
            Assert.That(Calculator.Add(num1, num2), Is.EqualTo(4.6f), "Somma corretta");
        }

        [Test]
        [TestCase(5.5f, 3.1f)]
        public void SubtractTest(float num1, float num2)
        {
            Assert.That(Calculator.Subtract(num1, num2), Is.EqualTo(2.4f), "Sottrazione corretta");
        }

        [Test]
        [TestCase(4.5f, 1.5f)]
        public void DivideTest(float num1, float num2)
        {
            Assert.That(Calculator.Divide(num1, num2), Is.EqualTo(3f), "Divisione corretta");
        }

        [Test]
        [TestCase(4.5f, 0)]
        public void DivideZero(float num1, float num2)
        {
            Assert.Throws<ArgumentException>(() => Calculator.Divide(num1, num2));
        }

        [Test]
        [TestCase(2.5f, 3f)]
        public void MultiplyTest(float num1, float num2)
        {
            Assert.That(Calculator.Multiply(num1, num2), Is.EqualTo(7.5f), "Moltiplicazione corretta");
        }
    }
}