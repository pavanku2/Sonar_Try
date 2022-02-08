namespace Sonar
{
    public class MathsOperations
    {
        //Created dummy variable to validate sonar check
         bool res = false;
        public int Add(int x, int y)
        {    if(x < 0 || y < 0)
            {
                return 0;
            }
            return x + y;
        }
    }
}
