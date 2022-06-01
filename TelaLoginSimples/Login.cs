using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNenviar_Click(object sender, EventArgs e)
        {
            string user;
            string password;
            user = textUser.Text;
            password = textPassword.Text;
            MessageBox.Show("Nome: " + user + "\n" + "Senha: " + password + "\nLogado com sucesso.");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
