using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourFlashApp.Views;

namespace YourFlashApp
{
    public  class MenuStripClass
    {
        public MenuStrip menuStrip1;
        public MenuStripClass()
        {

            menuStrip1 = new MenuStrip();

            ToolStripMenuItem home = new ToolStripMenuItem("Home");

            home.Click += home_Click;
            menuStrip1.Items.Add(home);

            ToolStripMenuItem study = new ToolStripMenuItem("Study");
            study.Click += study_Click;
            menuStrip1.Items.Add(study);

            ToolStripMenuItem newWord = new ToolStripMenuItem("New Word");
            newWord.Click += newWord_Click;
            menuStrip1.Items.Add(newWord);


            ToolStripMenuItem flashcards = new ToolStripMenuItem("Flashcards");
            flashcards.Click += flashcards_Click;
            menuStrip1.Items.Add(flashcards);

            menuStrip1.BackColor = Color.Yellow;
            menuStrip1.Font =  new Font("Cambria", 10);

        }


        void home_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
        }
       
        void newWord_Click(object sender, EventArgs e)
        {
            NewWordForm form = new NewWordForm();
            form.Show();
        }
        void study_Click(object sender, EventArgs e)
        {
            StudyForm form = new StudyForm();
            form.ShowDialog();
        }
        void flashcards_Click(object sender, EventArgs e)
        {
            FlashcardsForm form = new FlashcardsForm();
            form.Show();
        }
    }
}
