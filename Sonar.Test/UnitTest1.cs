using Xunit;


namespace Sonar.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }


        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(4, 3, 7)]
        [InlineData(-10, 10, 0)]
        [InlineData(-10, -10, -20)]
        public void Addition_ShouldCalculateSimpleValues(int num1, int num2, int expected)
        {
            // Action
            WeatherForecast weatherForecast = new WeatherForecast();

            int actual = weatherForecast.Add(num1, num2);

            // Assertion
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(-9, 3, -3)]
        public void Division_ShouldCalculateSimpleValues(double num1, double num2, double expected)
        {
            WeatherForecast weatherForecast = new WeatherForecast();

            // Action
            double actual = weatherForecast.Division(num1, num2);

            // Assertion
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_ShouldDivideByZero()
        {
            WeatherForecast weatherForecast = new WeatherForecast();

            // dummy    comment
            double expected = 0;

            // Action
            double actual = weatherForecast.Division(15, 0);

            // Assertion
            Assert.Equal(expected, actual);
        }
    }
}