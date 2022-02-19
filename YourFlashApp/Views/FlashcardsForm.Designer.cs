
namespace YourFlashApp
{
    partial class FlashcardsForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Filter_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memorized_filter = new System.Windows.Forms.CheckBox();
            this.filter_box = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 409);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Filter_button
            // 
            this.Filter_button.BackColor = System.Drawing.Color.White;
            this.Filter_button.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter_button.ForeColor = System.Drawing.Color.YellowGreen;
            this.Filter_button.Location = new System.Drawing.Point(537, 3);
            this.Filter_button.Name = "Filter_button";
            this.Filter_button.Size = new System.Drawing.Size(130, 49);
            this.Filter_button.TabIndex = 1;
            this.Filter_button.Text = "Show";
            this.Filter_button.UseVisualStyleBackColor = false;
            this.Filter_button.Click += new System.EventHandler(this.Filter_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memorized_filter);
            this.panel1.Controls.Add(this.filter_box);
            this.panel1.Controls.Add(this.Filter_button);
            this.panel1.Location = new System.Drawing.Point(45, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 55);
            this.panel1.TabIndex = 2;
            // 
            // memorized_filter
            // 
            this.memorized_filter.AutoSize = true;
            this.memorized_filter.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.memorized_filter.ForeColor = System.Drawing.Color.YellowGreen;
            this.memorized_filter.Location = new System.Drawing.Point(268, 14);
            this.memorized_filter.Name = "memorized_filter";
            this.memorized_filter.Size = new System.Drawing.Size(152, 32);
            this.memorized_filter.TabIndex = 3;
            this.memorized_filter.Text = "Memorized";
            this.memorized_filter.UseVisualStyleBackColor = true;
            // 
            // filter_box
            // 
            this.filter_box.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.filter_box.ForeColor = System.Drawing.Color.YellowGreen;
            this.filter_box.FormattingEnabled = true;
            this.filter_box.Location = new System.Drawing.Point(27, 11);
            this.filter_box.Name = "filter_box";
            this.filter_box.Size = new System.Drawing.Size(184, 35);
            this.filter_box.TabIndex = 2;
            this.filter_box.Text = "Filters";
            // 
            // FlashcardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(765, 600);
            this.MinimumSize = new System.Drawing.Size(765, 600);
            this.Name = "FlashcardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flashcards";
            this.Load += new System.EventHandler(this.Flashcards_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Filter_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filter_box;
        private System.Windows.Forms.CheckBox memorized_filter;
    }
}