﻿namespace Sonar
{
    public class MathsOperations
    {
        public int Add(int x, int y)
        {    if(x < 0 || y < 0)
            {
                return 0;
            }
            return x + y;
        }
    }
}
