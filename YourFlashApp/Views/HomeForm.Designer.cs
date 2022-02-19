
namespace YourFlashApp
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.memorized_Count = new System.Windows.Forms.Label();
            this.inProgress_Count = new System.Windows.Forms.Label();
            this.allWords_Count = new System.Windows.Forms.Label();
            this.memorized_label = new System.Windows.Forms.Label();
            this.inProgress_label = new System.Windows.Forms.Label();
            this.allWords_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.addWord_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.memorized_Count);
            this.panel1.Controls.Add(this.inProgress_Count);
            this.panel1.Controls.Add(this.allWords_Count);
            this.panel1.Controls.Add(this.memorized_label);
            this.panel1.Controls.Add(this.inProgress_label);
            this.panel1.Controls.Add(this.allWords_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 167);
            this.panel1.TabIndex = 0;
            // 
            // memorized_Count
            // 
            this.memorized_Count.AutoSize = true;
            this.memorized_Count.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorized_Count.ForeColor = System.Drawing.Color.YellowGreen;
            this.memorized_Count.Location = new System.Drawing.Point(511, 96);
            this.memorized_Count.Name = "memorized_Count";
            this.memorized_Count.Size = new System.Drawing.Size(35, 38);
            this.memorized_Count.TabIndex = 7;
            this.memorized_Count.Text = "0";
            // 
            // inProgress_Count
            // 
            this.inProgress_Count.AutoSize = true;
            this.inProgress_Count.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inProgress_Count.ForeColor = System.Drawing.Color.Gold;
            this.inProgress_Count.Location = new System.Drawing.Point(377, 96);
            this.inProgress_Count.Name = "inProgress_Count";
            this.inProgress_Count.Size = new System.Drawing.Size(35, 38);
            this.inProgress_Count.TabIndex = 6;
            this.inProgress_Count.Text = "0";
            // 
            // allWords_Count
            // 
            this.allWords_Count.AutoSize = true;
            this.allWords_Count.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allWords_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.allWords_Count.Location = new System.Drawing.Point(260, 96);
            this.allWords_Count.Name = "allWords_Count";
            this.allWords_Count.Size = new System.Drawing.Size(35, 38);
            this.allWords_Count.TabIndex = 1;
            this.allWords_Count.Text = "0";
            // 
            // memorized_label
            // 
            this.memorized_label.AutoSize = true;
            this.memorized_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorized_label.Location = new System.Drawing.Point(476, 72);
            this.memorized_label.Name = "memorized_label";
            this.memorized_label.Size = new System.Drawing.Size(108, 23);
            this.memorized_label.TabIndex = 5;
            this.memorized_label.Text = "Memorized";
            // 
            // inProgress_label
            // 
            this.inProgress_label.AutoSize = true;
            this.inProgress_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inProgress_label.Location = new System.Drawing.Point(344, 72);
            this.inProgress_label.Name = "inProgress_label";
            this.inProgress_label.Size = new System.Drawing.Size(107, 23);
            this.inProgress_label.TabIndex = 4;
            this.inProgress_label.Text = "In progress";
            // 
            // allWords_label
            // 
            this.allWords_label.AutoSize = true;
            this.allWords_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allWords_label.Location = new System.Drawing.Point(234, 72);
            this.allWords_label.Name = "allWords_label";
            this.allWords_label.Size = new System.Drawing.Size(90, 23);
            this.allWords_label.TabIndex = 3;
            this.allWords_label.Text = "All words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Progress";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(88, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(133, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(251, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(248, 168);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.onAddWord_Click);
            // 
            // addWord_label
            // 
            this.addWord_label.AutoSize = true;
            this.addWord_label.BackColor = System.Drawing.Color.Transparent;
            this.addWord_label.Font = new System.Drawing.Font("Cambria", 19.8F);
            this.addWord_label.ForeColor = System.Drawing.Color.YellowGreen;
            this.addWord_label.Location = new System.Drawing.Point(252, 437);
            this.addWord_label.Name = "addWord_label";
            this.addWord_label.Size = new System.Drawing.Size(247, 38);
            this.addWord_label.TabIndex = 2;
            this.addWord_label.Text = "Add a new word";
            this.addWord_label.Click += new System.EventHandler(this.onAddWord_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 549);
            this.Controls.Add(this.addWord_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(765, 600);
            this.MinimumSize = new System.Drawing.Size(765, 600);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourFlash";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label memorized_label;
        private System.Windows.Forms.Label inProgress_label;
        private System.Windows.Forms.Label allWords_label;
        private System.Windows.Forms.Label memorized_Count;
        private System.Windows.Forms.Label inProgress_Count;
        private System.Windows.Forms.Label allWords_Count;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label addWord_label;
    }
}

