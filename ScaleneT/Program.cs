using System;
using System.Xml.Linq;

namespace ScaleneT
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            //Prajakta Pradeep Pakhale - Student ID - 8895753
            string result;
            //orginal code
            //if((firstAngle != secondAngle) && (secondAngle != thirdAngle))

            //mutant
            if ((firstAngle == secondAngle) && (secondAngle == thirdAngle))
            {
                result = "The triangle is SCALENE Triangle";
            }
            else
            {
                result = "NOT A SCALENE TRIANGLE";
            }
            return result;

        }

        static void Main(string[] args)
        {
        }
    }
}

