using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова
{
    internal static class Program
    {
        public static int ActionCounter = 0;
        internal static User CurrentUser;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        
        public static void IncrementAction()
        {
            ActionCounter++;
            if (ActionCounter >= 8)
            {
                ShowAuthForm();
            }
        }

        // Сброс счётчика
        public static void ResetCounter()
        {
            ActionCounter = 0;
        }

        // Вызов AuthForm
        private static void ShowAuthForm()
        {
            var authForm = new AuthForm();
            MainForm mainForm = new MainForm();
            var result = authForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ResetCounter();
                mainForm.Show();
                authForm.Close();


            }
            else
            {
                var loginForm = new LoginForm();
                loginForm.Show();

                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(f is LoginForm))
                        f.Hide();
                }
                ResetCounter();
            }
        }
    }
}


