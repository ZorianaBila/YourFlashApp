
namespace YourFlashApp.Views
{
    partial class FlashCardDetail
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.categories_combobox = new System.Windows.Forms.ComboBox();
            this.examlpe_textbox = new System.Windows.Forms.TextBox();
            this.eng_textbox = new System.Windows.Forms.TextBox();
            this.ukr_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Gold;
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cancel_button.Location = new System.Drawing.Point(40, 424);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(202, 57);
            this.cancel_button.TabIndex = 24;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Gold;
            this.save_button.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.save_button.Location = new System.Drawing.Point(501, 424);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(202, 57);
            this.save_button.TabIndex = 23;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // categories_combobox
            // 
            this.categories_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_combobox.Font = new System.Drawing.Font("Cambria", 18F);
            this.categories_combobox.FormattingEnabled = true;
            this.categories_combobox.Location = new System.Drawing.Point(514, 97);
            this.categories_combobox.Name = "categories_combobox";
            this.categories_combobox.Size = new System.Drawing.Size(189, 44);
            this.categories_combobox.TabIndex = 22;
            // 
            // examlpe_textbox
            // 
            this.examlpe_textbox.AllowDrop = true;
            this.examlpe_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examlpe_textbox.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examlpe_textbox.Location = new System.Drawing.Point(40, 306);
            this.examlpe_textbox.Name = "examlpe_textbox";
            this.examlpe_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.examlpe_textbox.Size = new System.Drawing.Size(663, 43);
            this.examlpe_textbox.TabIndex = 21;
            // 
            // eng_textbox
            // 
            this.eng_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eng_textbox.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eng_textbox.Location = new System.Drawing.Point(40, 98);
            this.eng_textbox.Name = "eng_textbox";
            this.eng_textbox.Size = new System.Drawing.Size(254, 43);
            this.eng_textbox.TabIndex = 20;
            // 
            // ukr_textbox
            // 
            this.ukr_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ukr_textbox.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ukr_textbox.Location = new System.Drawing.Point(40, 203);
            this.ukr_textbox.Name = "ukr_textbox";
            this.ukr_textbox.Size = new System.Drawing.Size(254, 43);
            this.ukr_textbox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(508, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(34, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Example";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "English";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(34, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ukrainian";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Tomato;
            this.delete_button.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.delete_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete_button.Location = new System.Drawing.Point(272, 424);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(202, 57);
            this.delete_button.TabIndex = 25;
            this.delete_button.Text = "Delete word";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // FlashCardDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 553);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.categories_combobox);
            this.Controls.Add(this.examlpe_textbox);
            this.Controls.Add(this.eng_textbox);
            this.Controls.Add(this.ukr_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(765, 600);
            this.MinimumSize = new System.Drawing.Size(765, 600);
            this.Name = "FlashCardDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashCardDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox categories_combobox;
        private System.Windows.Forms.TextBox examlpe_textbox;
        private System.Windows.Forms.TextBox eng_textbox;
        private System.Windows.Forms.TextBox ukr_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_button;
    }
}