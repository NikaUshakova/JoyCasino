using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JoyCasino.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        double money ;
        int rate;
        double ratemoney;
        
        private void MenuForm_Load(object sender, EventArgs e)
        {
            MoneyLabel.Text = 1000.ToString();
        }

        private void StavkaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                e.Handled = true;
            return;
        }

        private void n1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        public static double DoRateRed(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
            MessageBox.Show("Выпало число: "+number.ToString());
            if(red.Contains(number))
            { 
                    money = money + ratemoney * 1.5;
            }
                else money = money - ratemoney * 1.5;
                       
            return money ;

        }

        private void redd_MouseClick(object sender, MouseEventArgs e)
        {
           // if (StavkaTextBox.Text == "") MessageBox.Show("Введите размер ставки!");
            try
            {
                money = double.Parse(MoneyLabel.Text);
                ratemoney = double.Parse(StavkaTextBox.Text);
                MoneyLabel.Text = DoRateRed(ratemoney, money).ToString();
            }
            catch
            {
                MessageBox.Show("Введите размер ставки!");
                return;
            }
        }

        public static double DoRateBlack(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
            MessageBox.Show("Выпало число: " + number.ToString());
            if (black.Contains(number))
            {
                money = money + ratemoney * 1.5;
            }
            else money = money - ratemoney * 1.5;
            return money;

        }

        private void uberblack_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                money = double.Parse(MoneyLabel.Text);
                ratemoney = double.Parse(StavkaTextBox.Text);
                MoneyLabel.Text = DoRateBlack(ratemoney, money).ToString();
            }
            catch
            {
                MessageBox.Show("Введите размер ставки!");
                return;
            }
        }

        public static double DoRate1_3(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] first = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12 };
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
            MessageBox.Show("Выпало число: " + number.ToString());
            if (first.Contains(number))
            {
                money = money + ratemoney * 1.67;
            }
            else money = money - ratemoney * 1.67;
            return money;

        }
        public static double DoRate2_3(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] first = new int[] { 13,14,15,16,17,18,19,20,21,22,23,24 };
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
            MessageBox.Show("Выпало число: " + number.ToString());
            if (first.Contains(number))
            {
                money = money + ratemoney * 1.67;
            }
            else money = money - ratemoney * 1.67;
            return money;

        }
        public static double DoRate3_3(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int[] first = new int[] { 25,26,27,28,29,30,31,32,33,34,35,36};
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(0, 37);
            MessageBox.Show("Выпало число: " + number.ToString());
            if (first.Contains(number))
            {
                money = money + ratemoney * 1.67;
            }
            else money = money - ratemoney * 1.67;
            return money;

        }

        private void n1_3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                money = double.Parse(MoneyLabel.Text);
                ratemoney = double.Parse(StavkaTextBox.Text);
                MoneyLabel.Text = DoRate1_3(ratemoney, money).ToString();
            }
            catch
            {
                MessageBox.Show("Введите размер ставки!");
                return;
            }
        }

        private void n2_3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                money = double.Parse(MoneyLabel.Text);
                ratemoney = double.Parse(StavkaTextBox.Text);
                MoneyLabel.Text = DoRate2_3(ratemoney, money).ToString();
            }
            catch
            {
                MessageBox.Show("Введите размер ставки!");
                return;
            }
        }

        private void n3_3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                money = double.Parse(MoneyLabel.Text);
                ratemoney = double.Parse(StavkaTextBox.Text);
                MoneyLabel.Text = DoRate3_3(ratemoney, money).ToString();
            }
            catch
            {
                MessageBox.Show("Введите размер ставки!");
                return;
            }
        }

        public static double DoRateZero(/*int rateчисло*/ double ratemoney/*ставка денежная*/, double money)
        {
            int zero = 0;
            //if (money < ratemoney) Console.WriteLine("У вас недостаточно денежных средств. Сделайте ставку меньше.");
            //if (money <= 0) Console.WriteLine("Введенная ставка меньше 0(=0). Введите положительное число");
            Random rnd = new Random();
            int number = 0;
            number = rnd.Next(-1, 37);
            MessageBox.Show("Выпало число: " + number.ToString());
            if (number == zero)
            {
                money = money + ratemoney * 36;
            }
            else money = money - ratemoney * 36;
            return money;

        }

        private void zerobutton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                money = double.Parse(MoneyLabel.Text);
                ratemoney = double.Parse(StavkaTextBox.Text);
                MoneyLabel.Text = DoRateZero(ratemoney, money).ToString();
            }
            catch
            {
                MessageBox.Show("Введите размер ставки!");
                return;
            }
        }
    }
}
