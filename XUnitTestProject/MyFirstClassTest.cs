using System;
using FluentAssertions;
using mutation_testing;
using Xunit;

namespace XUnitTestProject
{
    public class MyFirstClassTest
    {
        [Fact]
        public void MultiplyEvenNumberBySixShouldThrowExceptionWhenOddNumberIsGiven()
        {
            //Arrange
            var myobject = new MyFirstClass();

            //Act
            Action task = () => { myobject.MultiplyEvenNumberBySix(1); };

            //Assert
            var result = task.Should().Throw<ArgumentException>().WithMessage("number can only be an even number");
        }
 
        [Fact]
        public void MultiplyEvenNumberBySixShouldReturn24With4()
        {
            //Arrange
            var myobject = new MyFirstClass();

            //Act
            var result = myobject.MultiplyEvenNumberBySix(4);

            //Assert
            result.Should().Be(24);
        }
    }
}
