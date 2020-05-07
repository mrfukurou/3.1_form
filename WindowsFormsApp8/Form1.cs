using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
            static double f(double x1, double y1, double x2, double y2)
            {
                x1 -= x2;
                y1 -= y2;
                return Math.Sqrt(x1 * x1 + y1 * y1);
            }
           static double max(double a, double b)
            {
                if (a < b) return b;
                else return a;
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(X1.Text);
                double y1 = Convert.ToDouble(Y1.Text);
                double x2 = Convert.ToDouble(X2.Text);
                double y2 = Convert.ToDouble(Y2.Text);
                double x3 = Convert.ToDouble(X3.Text);
                double y3 = Convert.ToDouble(Y3.Text);

                double a = f(0, 0, x1, y1);
                double b = f(0, 0, x2, y2);
                double c = f(0, 0, x3, y3);

                rez1.Text = Convert.ToString(a);
                rez2.Text = Convert.ToString(b);
                rez3.Text = Convert.ToString(c);


                double Max;

                Max = max((max(f(0, 0, x1, y1),  f(0, 0, x2, y2))), max (f(0, 0, x3, y3), (f(0, 0, x2, y2))));
                if (Max == a) { rezult.Text = Convert.ToString("Первая точка - "+Max); }
                else if (Max == b) { rezult.Text = Convert.ToString("Вторая точка - " + Max); }
                else { rezult.Text = Convert.ToString("Третья точка - " + Max); }
            }
            catch { 
                rezult.Text = Convert.ToString("Некорректный ввод!");
                rez1.Clear();
                rez2.Clear();
                rez3.Clear();

            }

        }
    }
}
