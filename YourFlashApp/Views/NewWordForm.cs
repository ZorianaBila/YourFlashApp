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
    public partial class NewWordForm : Form
    {
        NewWordViewModel newWordViewModel = new NewWordViewModel();
        
        public NewWordForm()
        {
            InitializeComponent();

            MenuStripClass menuStrip = new MenuStripClass();
            menuStrip.menuStrip1.Click += MenuStrip1_Click;
            Controls.Add(menuStrip.menuStrip1);
            LoadCategories();
            categories_combobox.SelectedIndex = 0;
        }

        private void LoadCategories()
        {
            List<string> categoriesName = new List<string>();

            newWordViewModel.onChooseCategories( categoriesName);
            foreach(string name in categoriesName)
            {
                categories_combobox.Items.Add(name);

            }
        } 
        private void MenuStrip1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            newWordViewModel.UkrWord = ukr_textbox.Text;
            newWordViewModel.EngWord = eng_textbox.Text;
            newWordViewModel.ExampleSentence = examlpe_textbox.Text;
            newWordViewModel.Category = categories_combobox.SelectedItem.ToString();
            newWordViewModel.OnSave();
            MyMessageBox myMessageBox = new MyMessageBox();

            if (newWordViewModel.ValidateSave())
            {
                myMessageBox.ShowMessage($"A new flashcard\n'{newWordViewModel.EngWord}'\nis created ");
           }
            else myMessageBox.ShowError($"Fill all fields!\nOR\nUse only letters!");


            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                tb.Text = string.Empty;

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            NewCategoryForm form = new NewCategoryForm();
            form.Show();
            this.Hide();
            

        }
    }
}
