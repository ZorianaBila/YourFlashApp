using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourFlashApp.ViewModels;
using YourFlashApp.Views;

namespace YourFlashApp
{
    public partial class NewCategoryForm : Form
    {
        NewCategoryViewModel newCategoryViewModel = new NewCategoryViewModel();
        public NewCategoryForm()
        {
            InitializeComponent();

        }
       
        private void color_Button_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if(colorResult == DialogResult.OK)
            {
                color_Panel.BackColor = colorDialog1.Color;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            newCategoryViewModel.Name = categoryName_textbox.Text;
            newCategoryViewModel.Color = colorDialog1.Color;
            newCategoryViewModel.OnSave();
            MyMessageBox myMessageBox = new MyMessageBox();
            if (newCategoryViewModel.ValidateSave())
            {
                NewWordForm form = new NewWordForm();
                form.Show();
                this.Hide();

            }
            else if(newCategoryViewModel.IsCategoryExist == true)
            {
                myMessageBox.ShowError("The category already exists");
            }
            else myMessageBox.ShowError("Fill all fields");

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            NewWordForm form = new NewWordForm();
            form.Show();
            this.Hide();
        }
    }
}
