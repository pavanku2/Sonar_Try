namespace Sonar
{
    public class MathsOperations
    {
        //Created dummy variable to validate sonar check
         bool res = false;
         int UserId = 1;
         string Password = "password";

        public MathsOperations()
        {

        }
       

        public void AnotherExampleOfBadCode()
        {
            bool option1 = false;
            bool option2 = false;
            bool option3 = false;

            if (option1)
            {
                if (option2)
                {
                    if (option3)
                    {
                       // doThing2();
                    }
                    else
                    {
                        //doThing1(); 
                    }
                }
                else
                {
                    //doThing1(); // need to do the same as above
                }
            }
            else
            {
                //more or less the same as above
            }
        }

        public int Add(int x, int y)
        {
            try
            {
                if (x < 0 || y < 0)
                {
                    //return -1; // commented code
                    return 0;
                }
                return x + y;

            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {

            }
            
        }
    }
}
