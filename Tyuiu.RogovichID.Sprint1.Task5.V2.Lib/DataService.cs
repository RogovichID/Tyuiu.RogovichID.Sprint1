using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RogovichID.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double c = (temp - 32) * 5 / 9;
            return (int)Convert.ToInt32(c);
        }
    }
}
