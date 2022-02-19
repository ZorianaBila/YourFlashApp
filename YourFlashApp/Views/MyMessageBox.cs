using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFlashApp.Views
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ShowInTaskbar = false;
        }

        public void ShowMessage(string text)
        {
            this.Show();
            label.Text = text;
            label.Font = new Font("Cambria", 14);
            label.BackColor = Color.White;
            label.Location = new Point(this.Width / 2 - label.Width / 2, 20);
            label.ForeColor = Color.Green;
        }
        public void ShowError(string text)
        {
            this.Show();
            label.Text = text;
            label.Font = new Font("Cambria", 14);
            label.BackColor = Color.White;
            label.Location = new Point(this.Width / 2 - label.Width / 2, this.Height / 2 - label.Height / 2 - button_OK.Height);
            label.ForeColor = Color.Red;

        }

        public void button_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
