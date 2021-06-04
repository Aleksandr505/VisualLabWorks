using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLabWorks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int secret = 1;
        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            crazyPanel.BackColor = Color.Red;
            impossibleLabel.BackColor = Color.Black;
            impossibleLabel.ForeColor = Color.White;
            if (secret % 10 == 0)
            {
                impossibleLabel.Text = "Secret in the details";
            }
            secret++;
        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            crazyPanel.BackColor = Color.Black;
            impossibleLabel.BackColor = Color.Red;
            impossibleLabel.ForeColor = Color.Black;
      
        }

        private void crazyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private int factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            const int n = 5; 
            String s = ArgBox.Text;
            try
            {
                int x = int.Parse(s.Trim());

                double sumSin = 0;
                for (int i = 0; i < n; i++)
                {
                    sumSin += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1)
                        / factorial(2 * i + 1);
                }

                impossibleLabel.Text = sumSin.ToString();
                advertisementLabel.Text = "Вычисление синуса:";
                advertisementLabel.ForeColor = Color.Green;
            } catch (Exception)
            {
                impossibleLabel.Text = "Ай, ай, ай, введите целочисленный аргумент!";
                advertisementLabel.Text = "Ошибочка вышла!";
                advertisementLabel.ForeColor = Color.Red;
            }
        }

        private void advertisementLabel_Click(object sender, EventArgs e)
        {

        }

        private void fakeButton_Click(object sender, EventArgs e)
        {
            const int n = 5;
            String s = ArgBox.Text;

            try
            {
                int x = int.Parse(s.Trim());

                double ex = 0;
                for (int i = 0; i <= n; i++)
                {
                    ex += Math.Pow(x, i) / factorial(i);
                }
                impossibleLabel.Text = ex.ToString();
                advertisementLabel.Text = "Вычисление экспоненты:";
                advertisementLabel.ForeColor = Color.Blue;
            } catch(Exception)
            {
                impossibleLabel.Text = "Ай, ай, ай, введите целочисленный аргумент!";
                advertisementLabel.Text = "Ошибочка вышла!";
                advertisementLabel.ForeColor = Color.Red;
            }
        }
    }
}
