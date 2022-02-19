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

namespace YourFlashApp.Views
{
    public partial class FlashCardDetail:Form
    {
        FlashCardDetailViewModel flashCardViewModel = new FlashCardDetailViewModel();

        Item item;
        public FlashCardDetail(Item item) 
        {
            InitializeComponent();

            LoadCategories();
            this.item = item;
            ukr_textbox.Text = item.UkrWord;
            eng_textbox.Text = item.EngWord;
            examlpe_textbox.Text = item.ExampleSentence;
            categories_combobox.SelectedItem = item.Category;
        }
        private void LoadCategories()
        {
            List<string> categoriesName = new List<string>();

            flashCardViewModel.onChooseCategories(categoriesName);
            foreach (string name in categoriesName)
            {
                categories_combobox.Items.Add(name);

            }
        }
        

        private void save_button_Click(object sender, EventArgs e)
        {
            flashCardViewModel.UkrWord = ukr_textbox.Text;
            flashCardViewModel.EngWord = eng_textbox.Text;
            flashCardViewModel.ExampleSentence = examlpe_textbox.Text;
            flashCardViewModel.Category = categories_combobox.SelectedItem.ToString();
            flashCardViewModel.OnSave(item.Id);

            MyMessageBox myMessageBox = new MyMessageBox();
            if (flashCardViewModel.ValidateSave())
            {
                CloseFrom();
                myMessageBox.ShowMessage($"The flashcard\n'{flashCardViewModel.EngWord}'\nis updated!");
            }
            else myMessageBox.ShowError($"Fill all fields!\nOR\nUse only letters!");


        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            CloseFrom();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            flashCardViewModel.onDelete(item.Id);
            CloseFrom();
        }
        private void CloseFrom()
        {
            FlashcardsForm form = new FlashcardsForm();
            form.Show();
            this.Hide();
        }
    }
}
