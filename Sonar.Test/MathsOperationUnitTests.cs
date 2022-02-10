using Sonar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SonarTest
{
    public class MathsOperationUnitTests
    {
        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(4, 3, 7)]
        [InlineData(-10, 10, 0)]
        [InlineData(-10, -10, 0)]
        public void Addition_ShouldCalculateSimpleValues(int num1, int num2, int expected)
        {
            // Action
            MathsOperations data = new MathsOperations();

            int actual = data.Add(num1, num2);

            // Assertion
            Assert.Equal(expected, actual);
        }
    }
}
