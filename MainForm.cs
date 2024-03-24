using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class MainForm : Form
    {
        string capitalLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerLetter = "abcdefghijklmnopqrstuvwxyz";
        string symbols = "!@#$%^&*()_+-|?><:}{";
        string numbers = "1234567890";
        string allChar = "";
        string passwords = "";
        string copyPassword = "";
        private int scrollValue;
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reply = MessageBox.Show(
                "Вы действительно хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
            if (reply == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void SizeScroll(object sender, ScrollEventArgs e)
        {
            scrollValue = e.NewValue;
            sizeBox.Text = scrollValue.ToString();
        }

        private void sizeScroll(object sender, EventArgs e)
        {
            sizeBox.Text = $"{SizeScrollBox.Value}";
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                passwords = ""; // обнуление пароля
                if (scrollValue == 0)
                {
                    MessageBox.Show("Длина пароля должна быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                allChar = capitalLetter + lowerLetter;
                if (numberBox.Checked == true)
                {
                    allChar += numbers;
                }

                if (symbolsBox.Checked == true)
                {
                    allChar += symbols;
                }

                for (int i = 0; i < scrollValue; i++)
                {
                    int index = random.Next(0, allChar.Length);
                    passwords += allChar[index];
                }
                textBox1.Text = $"{passwords}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwords))
            {
                Clipboard.SetText(passwords);
                MessageBox.Show("Пароль скопирован");
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
