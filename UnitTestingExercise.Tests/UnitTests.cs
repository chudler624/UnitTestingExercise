using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:


            //Arrange
            // create a Calculator object
            var instance = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = instance.Add(num1, num2, num3);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]//Add test data <-------
        public void SubtractTest(int x, int y, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var instance1 = new Calculator();
            //Act
            var actual1= instance1.Subtract(x, y);
            //Assert
            Assert.Equal(expected, actual1);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance2 = new Calculator();
            //Act
            var actual2 = instance2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData(8, 4, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var instance3 = new Calculator();
            //Act
            var actual3  = instance3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual3);
        }

    }
}
