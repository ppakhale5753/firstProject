using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using ScaleneT;

namespace Triangle;
public class TestClass1
{
    //Prajakta Pradeep Pakhale - Student ID - 8895753
    [TestFixture]

    public class TestClass1_1
    {
        [Test]
        public void Valid_SCALENE_Triangle()
        {

            //Arrange
            int firstAngle = 10;
            int secondAngle = 20;
            int thirdAngle = 30;

            string expected = "The triangle is SCALENE Triangle";

            //act
            string actual = ScaleneT.Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
