using System;

namespace JCSCos
{
    public static class CosApproximation
    {

        static double factorial(double num)
        {
            if (num > 1)
                return num * factorial(num - 1);
            return 1;
        }

        #region Radian Cosine
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on radians
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double ApCos(this double x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on radians
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double ApCos(this float x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on radians
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double ApCos(this long x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on radians
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double ApCos(this int x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on radians
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double ApCos(this short x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result;
        }
        #endregion

        #region Degree Cosine
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on degree
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double DegreeApCos(this double x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result * 180/Math.PI;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on degree
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double DegreeApCos(this float x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result * 180/Math.PI;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on degree
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double DegreeApCos(this long x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result * 180/Math.PI;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on degree
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double DegreeApCos(this int x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result * 180/Math.PI;
        }
        ///<summary>
        /// This method approximates and returns the cosine based on a ratio which is 100 by default. It is based on degree
        /// </summary>
        /// <returns>Approximate cosine of <paramref name="x"/></returns>
        /// <param name="x">The value whose cosine is calculated. based on radians</param>
        /// <param name="K_max">In fact, it is the same ratio based on which the cosine is approximated and it is set to 100 by default.</param>
        /// <remarks>Note: For microcontrollers and electronic boards, set <paramref name="K_max"/> to a number that matches the specifications of the hardware processor.</remarks>
        public static double DegreeApCos(this short x, int K_max = 100)
        {
            double result = 0;
            for (double k = 0; k < K_max; k++)
            {
                result += (Math.Pow(-1d, k) * Math.Pow(x, (2d * k))) / factorial(2 * k);
            }
            return result * 180/Math.PI;
        }
        #endregion

    }
}
