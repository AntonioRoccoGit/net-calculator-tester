using net_calculator_tester.Classes;
namespace CalculatorTest
{
    public class CalculatorUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_NumberSum()
        {
            float number1 = 4;
            float number2 = 6;
            float resault = 10;
            float functionResault =Calculator.NumberSumm(number1, number2);

            Assert.True(functionResault == resault, TwoNumberErrorMessage("somma", resault.ToString(), functionResault.ToString()));
        }

        [Test]
        public void Test_NumberDiff()
        {
            float number1 = 15;
            float number2 = 5;
            float resault = 10;
            float functionResault = Calculator.NumberDiff(number1, number2);

            Assert.True(functionResault == resault, TwoNumberErrorMessage("sottrazione", resault.ToString(), functionResault.ToString()));
        }

        [Test]
        public void Test_NumberMultiplier()
        {
            float number1 = 10;
            float number2 = 5;
            float resault = 50;
            float functionResault = Calculator.NumberMultiplier(number1, number2);

            Assert.True(functionResault == resault, TwoNumberErrorMessage("moltiplicazione", resault.ToString(), functionResault.ToString()));
        }

        [Test]
        public void Test_NumberDivision()
        {
            float number1 = 10;
            float number2 = 5;
            float resault = 2;
            float functionResault = Calculator.NumberDivision(number1, number2);

            Assert.True(functionResault == resault, TwoNumberErrorMessage("divisione", resault.ToString(), functionResault.ToString()));
        }


        //FUNCTIONS
        public string TwoNumberErrorMessage(string operation, string resault, string functionResault )
        {
            string message = $"Il risultato della {operation} è errato{Environment.NewLine}" +
                             $"Atteso: {resault}{Environment.NewLine}" +
                             $"Generato: {functionResault}";
            return message;
        }
    }
}