using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourFlash.ViewModels;
using YourFlashApp.Models;




namespace YourFlashApp
{
    public partial class HomeForm : Form
    {
        HomeViewModel homeViewModel = new HomeViewModel();
        public HomeForm()
        {
            InitializeComponent();

            this.Text = "Your Flash";

            MenuStripClass menuStrip = new MenuStripClass();

            menuStrip.menuStrip1.Click += MenuStrip1_Click;

            Controls.Add(menuStrip.menuStrip1);

            allWords_Count.Text = homeViewModel.CountAllWords().ToString();
            inProgress_Count.Text = homeViewModel.CountInProgress().ToString();
            memorized_Count.Text = homeViewModel.CountMemorized().ToString();

        }

        private void MenuStrip1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private  void onAddWord_Click(object sender, EventArgs e)
        {
            NewWordForm form = new NewWordForm();
            form.Show();
            this.Hide();
        }
    }
    
}
