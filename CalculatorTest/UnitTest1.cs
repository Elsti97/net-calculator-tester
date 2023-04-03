using net_calculator_tester;

namespace CalculatorTest
{
    public class Tests
    {

        [Test]
        [TestCase(1.5f, 3.14f)]
        public void AddTest(float num1, float num2)
        {
            Assert.DoesNotThrow(() => Calculator.Add(num1, num2));
        }
    }
}