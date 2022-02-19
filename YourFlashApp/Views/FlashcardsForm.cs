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
using YourFlashApp.Services;
using YourFlashApp.ViewModels;
using YourFlashApp.Views;

namespace YourFlashApp
{
    public partial class FlashcardsForm : Form
    {
        FlashCardsViewModel flashCardsViewModel = new FlashCardsViewModel();
        private List<Item> items = new List<Item>();
        public FlashcardsForm()
        {
            InitializeComponent();

            MenuStripClass menuStrip = new MenuStripClass();
            menuStrip.menuStrip1.Click += MenuStrip1_Click;
            Controls.Add(menuStrip.menuStrip1);

            filter_box.Items.Add("All categories");
            LoadCategories();
            filter_box.SelectedIndex = 0;
        }
        private void MenuStrip1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private  void Flashcards_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flashCardsViewModel.LoadsItems(items);
            DrawFashCards(items,sender, e);
         
            
        }
        private void flashcard_Click(object sender, EventArgs e, Item item)
        {
            FlashCardDetail form = new FlashCardDetail(item);
            form.Show();
            this.Hide();
        }

        private void Filter_button_Click(object sender, EventArgs e)
        {
            flashCardsViewModel.FilterItems(items, filter_box.SelectedItem.ToString(), memorized_filter.Checked);
            flowLayoutPanel1.Controls.Clear();
            if(flashCardsViewModel.filtered.Count == 0)
            {
                MyMessageBox myMessageBox = new MyMessageBox();
                myMessageBox.ShowMessage("Soryy...\nWe cannot find\nsuch words");
            }
            DrawFashCards(flashCardsViewModel.filtered, sender, e);
            
        }
        private void LoadCategories()
        {
            List<string> categoriesName = new List<string>();

            flashCardsViewModel.onChooseCategories(categoriesName);
            foreach (string name in categoriesName)
            {
                filter_box.Items.Add(name);

            }
           

        }

        private void DrawFashCards(List<Item> items, object sender, EventArgs e)
        {
            foreach (Item item in items)
            {
                Category category = flashCardsViewModel.FindCategory(item);

                Panel panel = new Panel();
                panel.Size = new Size(230, 100);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label wordPanel = new Label();
                wordPanel.Text = item.EngWord;
                wordPanel.ForeColor = category.Color;
                wordPanel.Font = new Font("Cambria", 15);
                wordPanel.Location = new Point(panel.Width / 2 - wordPanel.PreferredWidth / 2, panel.Height / 2 - wordPanel.Height / 2);
                panel.Click += (clicked, r) => flashcard_Click(sender, e, item);
                wordPanel.Click += (clicked, r) => flashcard_Click(sender, e, item);
                panel.Controls.Add(wordPanel);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

    }
}
