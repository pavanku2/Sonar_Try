namespace Sonar
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public  double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public  double Multiplication(double num1, double num2)
        {
            if(num1 < 0)
            {
                return 0;
            }
            return num1 * num2; // test
        }

        public  double Division(double num1, double num2)
        { 
            // comment
            if(num1 ==0)
            {
                return 0;
            }
            if (num2 == 0)
            {
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}