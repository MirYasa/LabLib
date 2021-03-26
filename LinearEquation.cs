using System;
namespace Lab.MironGurevich
{
    public class GetLinearEquation
    {
        protected float Root(float a, float b)
        {
            if (a == 0)
            {
                throw new MironException("The equation does not exist");

            }
            MironLog.Log("This is linear equation");
            return (b * -1) / a;
        }
    }
}