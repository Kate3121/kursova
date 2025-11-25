using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсова
{
    public partial class AuthForm : Form
    {
        private double currentX;
        private const double a = 4.0;

        public AuthForm()
        {
            InitializeComponent();
            GenerateChallenge();
        }

        private void GenerateChallenge()
        {
            var rand = new Random();
            currentX = rand.Next(1, 5);
            lblChallenge.Text = $"X = {currentX} ";
            File.AppendAllText("ask.txt", $"X={currentX}\n");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtResponse.Text, out double userY))
            {
                MessageBox.Show("Невірний формат відповіді");
                return;
            }

            double expectedY = Math.Pow(2.3, a * currentX);
            if (Math.Abs(userY - expectedY) < 0.01)
            {
                Logger.Log("auth", "Правильна відповідь");
                MessageBox.Show("Автентифікація успішна");
            }
            else
            {
                Logger.Log("auth", $"Неправильна відповідь");
                MessageBox.Show($"Доступ заборонено. Повторіть вхід.");
               
            }
            this.Close();
        }

    }
}

