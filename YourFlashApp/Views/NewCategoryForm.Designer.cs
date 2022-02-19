
namespace YourFlashApp
{
    partial class NewCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName_textbox = new System.Windows.Forms.TextBox();
            this.color_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.color_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category name";
            // 
            // categoryName_textbox
            // 
            this.categoryName_textbox.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.categoryName_textbox.Location = new System.Drawing.Point(37, 56);
            this.categoryName_textbox.Name = "categoryName_textbox";
            this.categoryName_textbox.Size = new System.Drawing.Size(314, 39);
            this.categoryName_textbox.TabIndex = 1;
            // 
            // color_Panel
            // 
            this.color_Panel.BackColor = System.Drawing.Color.GreenYellow;
            this.color_Panel.Location = new System.Drawing.Point(37, 161);
            this.color_Panel.Name = "color_Panel";
            this.color_Panel.Size = new System.Drawing.Size(41, 41);
            this.color_Panel.TabIndex = 2;
            // 
            // color_Button
            // 
            this.color_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.color_Button.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.color_Button.Location = new System.Drawing.Point(146, 161);
            this.color_Button.Name = "color_Button";
            this.color_Button.Size = new System.Drawing.Size(205, 41);
            this.color_Button.TabIndex = 0;
            this.color_Button.Text = "Choose";
            this.color_Button.UseVisualStyleBackColor = false;
            this.color_Button.Click += new System.EventHandler(this.color_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a color for the category";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Gold;
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cancel_button.Location = new System.Drawing.Point(21, 283);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(164, 57);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Gold;
            this.save_button.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.save_button.Location = new System.Drawing.Point(335, 283);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(164, 57);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 386);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color_Button);
            this.Controls.Add(this.color_Panel);
            this.Controls.Add(this.categoryName_textbox);
            this.Controls.Add(this.label1);
            this.Name = "NewCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryName_textbox;
        private System.Windows.Forms.FlowLayoutPanel color_Panel;
        private System.Windows.Forms.Button color_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}