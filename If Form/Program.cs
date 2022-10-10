using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Form
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public class Logic
        {
            public static int Cmax(int[] mas)
            {

                int max = -10;

                for (int i = 0; i <= 2; i++)
                {
                    if (mas[i] > max)
                    {
                        max = mas[i];
                    }
                }
                return max;
            }

            public static void Separate(int x, int[] mas)
            {
                mas[0] = x / 100;
                mas[1] = x % 100 / 10;
                mas[2] = x % 100 % 10;
            }

            public static string Compare(int x)
            {
                int result;
                string outMessage;

                if ((x < 1000 && x >= 100) || (x > -1000 && x <= -100))
                {
                    int[] mas = new int[3];

                    Separate(x, mas);
                    result = Cmax(mas);

                    outMessage = Convert.ToString(result);
                }
                else
                {
                    outMessage = "Не трёхзначное число";
                }
                return outMessage;
            }
        }
    }
}
