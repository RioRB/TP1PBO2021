using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
            tbPass.MaxLength = 15;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login("admin", "pbo123");
            login.username = Convert.ToString(tbUser.Text);
            login.password = Convert.ToString(tbPass.Text);

            if (login.username != "admin")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = "Username yang diisikan salah";
                string title = "Close Window";
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
                
            else if (login.password != "pbo123")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = "Password yang diisikan salah";
                string title = "Close Window";
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
                
            else if ((login.password == "pbo123") && (login.username == "admin"))
            {
                 MessageBox.Show("Selamat Datang");

                Form2 f2 = new Form2();

            //    f2.lblUser.Text = login.username;
           //     f2.lblPass.Text = login.password;

                f2.Show();
                this.Hide();
            }
        }
    }
}
