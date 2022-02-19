using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourFlashApp.Models;
using YourFlashApp.ViewModels;
using YourFlashApp.Views;

namespace YourFlashApp
{
    public partial class StudyForm : Form
    {
        StudyViewModel studyViewModel;
        private bool FaceCard = false;
        private bool Remember = true;
       public StudyForm()
        {
            studyViewModel =  new StudyViewModel();
            InitializeComponent();
           
            show_Item();

        }
       
       

        private void reverse_Click(object sender, EventArgs e)
        {
            reverse_Card();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private void remember_button_Click(object sender, EventArgs e)
        {
            studyViewModel.OnRemember();
 
            if (studyViewModel.RefreshCard(Remember))
            {
                show_Item();
            }
            else
            {
                RepeatedAll();
            }

        }
        private void notRemember_button_Click(object sender, EventArgs e)
        {
            if (studyViewModel.RefreshCard(!Remember))
            {
                show_Item();
            }
            else
            {
                RepeatedAll();
            }
        }
        private void RepeatedAll()
        {
            HomeForm form = new HomeForm();
            form.Show();
            MyMessageBox myMessageBox = new MyMessageBox();
            myMessageBox.ShowMessage("You are amazing!\n\nYou have repeated all words\nin this category!");
            this.Hide();
        }
        private void show_Item()
        {
            English_label.Text = studyViewModel.item.EngWord;
            Ukrainian_label.Text = studyViewModel.item.UkrWord;
            Example_label.Text = studyViewModel.item.ExampleSentence;
            caregory_label.Text = studyViewModel.item.Category;
            English_label.Location = new Point(this.Width / 2 - English_label.Width / 2, this.Height / 3);
            Ukrainian_label.Location = new Point(this.Width / 2 - Ukrainian_label.Width / 2, this.Height/3);
            Example_label.Location = new Point(this.Width / 2 - Example_label.Width / 2, this.Height * 2 / 4 + 20);
            reverse_Card();
        }
        private void reverse_Card()
        {
            English_label.Visible = !FaceCard;
            remember_button.Visible = FaceCard;
            notRemember_button.Visible = FaceCard;
            Ukrainian_label.Visible = FaceCard;
            Example_label.Visible = !FaceCard;
            FaceCard = !FaceCard;
        }

        
    }
}
