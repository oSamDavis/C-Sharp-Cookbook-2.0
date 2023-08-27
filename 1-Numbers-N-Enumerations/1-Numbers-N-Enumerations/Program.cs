using System;

namespace Chptr1
{
    class Program
    {
        static void Print(string arg)
        {
            Console.WriteLine(arg);
        }
        static void Main(string[] args)
        {

            Print("****** Testing 1.1 *******");
            bool isApproximate = IsApproximateEqualTo(1, 3, 0.3333333, .000001);
            if (isApproximate)
            {
                Print("An approximate value was provided.");
            }
            else
            {
                Print("The value provided was not approximate" +
                    " enough.");
            }

            Print("\n****** Testing 1.2 *******");
            double rightAngleRadians = ConvertDegreesToRadians(90);
            Print("90 degrees = " + rightAngleRadians.ToString() + " radians");

            Print("\n****** Testing 1.3 *******");
            double degrees = ConvertDegreesToRadians(2);
            Print("2 radians = " + degrees.ToString() + " degrees");

            // TODO: Add testing for 1.4

            Print("\n****** Testing 1.5 *******");
            int num = 97;
            if (IsEven(num))
            {
                Print($"{num} is Even");
            }
            else
            {
                Print($"{num} is Odd");
            }

            long usersActive = 9219371576;
            if (IsOdd(usersActive))
            {
                Print($"{usersActive} is Odd");
            }
            else
            {
                Print($"{usersActive} is Even");
            }
        }

        // 1.1 Determining Approximate Equality Between a Fraction and a
        // Floating-Point Value

        // Problem: You need to compare a fraction with a value of type double
        // or float to determine whether they are within a close approximation
        // to each other.

        // Override that uses the System.Double.Epsilon value
        public static bool IsApproximateEqualTo(double numerator,
                                                double denominator,
                                                double dblValue)
        {
            return IsApproximateEqualTo(numerator,
                denominator, dblValue, Double.Epsilon);

        }

        // Override that allows for the specfication of an epsilon values.
        public static bool IsApproximateEqualTo(double numerator,
                                                double denominator,
                                                double dblValue,
                                                double epsilon)
        {
            // get the difference between the actual value and the dblValue.
            double difference = (numerator / denominator) - dblValue;

            // if the absolute val of the diff is greater than the epsilon,
            // it's a bad approximation.
            if (Math.Abs(difference) > epsilon)
            {
                return false;
            }
            else
            {
                // otherwise it is a good approximation.
                return true;
            }

        }


        // 1.2 Converting Degrees to Radians
        // Problem: When using trigonometric functions of the Math class, all
        // units are in radians. You'd have to convert any angles measured in
        // degrees to radians in order to use members of the Math class

        public static double ConvertDegreesToRadians(double degrees)
        {
            // radians = PI/180 * degrees
            double radians = (Math.PI / 180) * degrees;
            return radians;
        }

        // 1.3 Converting Radians to Degrees
        // Problem: When using trigonometric functions of the Math class, all
        // units are in radians. You may want to display a result in degress.

        public static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return degrees;
        }

        // TODO (oSamDavis): Look into 1.4 and complete it

        // 1.5 Testing for an Even or Odd Value
        public static bool IsEven(int val)
        {
            return val % 2 == 0;
        }

        // Implemented by using AND
        // NB: if val & 1 = 0 => Even else if val & 1 = 1 => Odd
        public static bool IsOdd(long val)
        {
            return (val & 1) == 1;
        }


    }



}