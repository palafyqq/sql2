using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using ksyusha.Services;
using System.Diagnostics.CodeAnalysis;


namespace ksyusha
{
    public partial class AuthForm : Form
    {
        Random rnd = new Random();
        string all = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";   
        int popito4ki = 1;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblCaptcha_Click(object sender, EventArgs e)
        {



        }
        private void lblEnterCaptcha_Click(object sender, EventArgs e)
        {

        }
        private void txtCaptcha_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbLogin.Text) && string.IsNullOrWhiteSpace(tbPassword.Text) && string.IsNullOrWhiteSpace(txtCaptcha.Text))
            {
                MessageBox.Show("Вы ничего не ввели", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
                
            if (tbLogin.Text == "plqq" && tbPassword.Text == "1234")
            {

                MessageBox.Show("Верный пароль");

            }
            else
            {
                if (lblCaptcha.Visible == false)
                {
                    popito4ki += 1;
                }
                
                if (popito4ki >= 3)
                {
                    MessageBox.Show("Вы неверно ввели данные 3 раза. Введите капчу");
                    captcha();
                    
                }
                else if (lblCaptcha.Visible = true)
                {
                    captcha();
                    
                }

                
            }
            
                
            
             void captcha()
             {
                lblPassword.Visible= false;
                lblLogin.Visible= false;
                tbPassword.Visible = false;
                tbLogin.Visible = false;
                lblCaptcha.Visible = true;
                txtCaptcha.Visible = true;
                lblEnterCaptcha.Visible = true;

                
                if (txtCaptcha.Text == lblCaptcha.Text)
                {
                    lblPassword.Visible = true;
                    lblLogin.Visible = true;
                    tbPassword.Visible = true;
                    tbLogin.Visible = true;
                    lblCaptcha.Visible = false;
                    lblEnterCaptcha.Visible = false;
                    txtCaptcha.Visible = false;
                    txtCaptcha.Text = null;
                    
                }
                else
                {
                    txtCaptcha.Text = null;
                }
                generate();
            }
            string generate()
            {
                lblCaptcha.Text = String.Empty;
                for (int i = 0; i < 5; ++i)
                {
                    lblCaptcha.Text += all[rnd.Next(all.Length)];
                }
                return txtCaptcha.Text;
            }

        }
    }
}