using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            string x1 = x.ToString();
            int d = 0;
            for (int i = 0; i != -1; ++i)
            {
                if (x1[i] == '.' || x1[i] == ',')
                {
                    d = Convert.ToInt32(x1[i + 1].ToString());
                    break;
                }
            }
            return d;
        }
    }
}
