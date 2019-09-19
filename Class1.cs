using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        
       
        
            [Test]
            public void GetAddition_Input3point4and5point6_Returns9point0()
            {
                //Arrange
                double number1 = 3.4;
                double number2 = 5.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input6and3_Returns3()
            {
                //Arrange
                double number1 = 6;
                double number2 = 3;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getmultiplication_Input3point4and5point6_Returns19point04()
            {
                //Arrange
                double number1 = 3.4;
                double number2 = 5.6;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input4point0and2point0_Returns2point0()
            {
                //Arrange
                double number1 = 4.0;
                double number2 = 2.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input5point0and6point0_Returns11point0()
            {
                //Arrange
                double number1 = 5.0;
                double number2 = 6.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input6and5_Returns1()
            {
                //Arrange
                double number1 = 6;
                double number2 = 5;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input6point0and5point0_Returns30point0()
            {
                //Arrange
                double number1 = 6.0;
                double number2 = 5.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input12point0and6point0_Returns2point0()
            {
                //Arrange
                double number1 = 12.0;
                double number2 = 6.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input9point0and3point0_Returns11point0()
            {
                //Arrange
                double number1 = 9.0;
                double number2 = 3.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input9and3_Returns6()
            {
                //Arrange
                double number1 = 9;
                double number2 = 3;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input9point0and3point0_Returns27point0()
            {
                //Arrange
                double number1 = 9.0;
                double number2 = 3.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input9point0and3point0_Returns3point0()
            {
                //Arrange
                double number1 = 9.0;
                double number2 = 3.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }


            