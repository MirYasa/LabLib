using System;
using System.Collections;
using System.Collections.Generic;
using Lab.core;
namespace Lab.MironGurevich
{
    public class GetQuadraticEquation : GetLinearEquation, EquationInterface
    {
        protected float GetDiscriminant(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return new List<float>() { (base.Root(b, c)) };
            }
            float d = GetDiscriminant(a, b, c);

            if (d < 0)
            {
                throw new MironException("The equation does not have solutions");
            }
            if (d == 0)
            {
                return new List<float>() { -b / (2 * a) };
            }
            MironLog.Log("This is quadratic equation");
            return new List<float>() { (-b + (float)Math.Sqrt(d)) / (2 * a), (-b - (float)Math.Sqrt(d)) / (2 * a) };
        }
    }
}