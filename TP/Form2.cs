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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/");
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            MessageBox.Show("Terima Kasih telah berkunjung");

            f1.Show();
            this.Close();
        }

        private void cbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImgWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/");
        }

        private void ImgLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            MessageBox.Show("Terima kasih telah berkunjung");

            f1.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
