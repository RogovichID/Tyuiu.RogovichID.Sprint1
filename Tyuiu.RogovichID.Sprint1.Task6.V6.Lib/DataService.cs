using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RogovichID.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] valueArr = value.Split(' ');
            for (int i = 0; i < valueArr.Length; i++)
            {
                if (valueArr[i].Length > 0)
                {
                    valueArr[i] = valueArr[i].Substring(1);
                }

            }
            return string.Join(" ", valueArr);
            

        }
    }
}
