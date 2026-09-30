using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RogovichID.Sprint1.Task3.V10.Lib;

public class DataService : ISprint1Task3V10
{
    public string NumberToMoney(double number)
    {
        number = Math.Round(number,3);
        int rub = (int)number;
        int kop = (int)Math.Round((number - rub) * 100);
        int rk;
        if (kop % 10 == 0)
        {
            rk = kop / 10;
        }
        else
        {
            rk = kop;
        }


        return $"{rub}.{rk} руб. - это {rub} руб. {kop} коп.";

    }
}
