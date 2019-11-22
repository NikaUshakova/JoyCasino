using System;
using System.Collections.Generic;
using System.Linq;

namespace CasinoLibrary
{
    public class UberBlack
    {
        int rate;
        double rateMoney = 1000;

        public static double DoRateBlack(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
            if (black.Contains(number))
            {
                money = money + ratemoney * 1.5;
            }
            else money = money - ratemoney * 1.5;
            return money;

        }

        public static double DoRateRed(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
          //  MessageBox.Show(number.ToString());
            if (red.Contains(number))
            {
                money = money + ratemoney * 1.5;
            }
            else money = money - ratemoney * 1.5;

            return money;

        }
    }
}
