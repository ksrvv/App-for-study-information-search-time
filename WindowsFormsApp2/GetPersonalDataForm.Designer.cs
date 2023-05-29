namespace WindowsFormsApp2
{
    partial class GetPersonalDataForm
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
            this.roundCornerButton1 = new WindowsFormsApp2.Controls.RoundCornerButton();
            this.groupTextBox = new WindowsFormsApp2.Controls.RoundCornerTextBox();
            this.nameTextBox = new WindowsFormsApp2.Controls.RoundCornerTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Для прохождения тестирования введите свои данные в поля ниже:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundCornerButton1
            // 
            this.roundCornerButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.roundCornerButton1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.roundCornerButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.roundCornerButton1.BorderRadius = 15;
            this.roundCornerButton1.BorderSize = 0;
            this.roundCornerButton1.FlatAppearance.BorderSize = 0;
            this.roundCornerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundCornerButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roundCornerButton1.ForeColor = System.Drawing.Color.White;
            this.roundCornerButton1.Location = new System.Drawing.Point(305, 342);
            this.roundCornerButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCornerButton1.Name = "roundCornerButton1";
            this.roundCornerButton1.Size = new System.Drawing.Size(188, 50);
            this.roundCornerButton1.TabIndex = 7;
            this.roundCornerButton1.Text = "Далее";
            this.roundCornerButton1.TextColor = System.Drawing.Color.White;
            this.roundCornerButton1.UseVisualStyleBackColor = false;
            this.roundCornerButton1.Click += new System.EventHandler(this.roundCornerButton1_Click);
            // 
            // groupTextBox
            // 
            this.groupTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.groupTextBox.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.groupTextBox.BorderRadius = 1;
            this.groupTextBox.BorderSize = 1;
            this.groupTextBox.ForeColor = System.Drawing.Color.Gray;
            this.groupTextBox.Location = new System.Drawing.Point(229, 244);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.groupTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.groupTextBox.PlaceholderText = "110102";
            this.groupTextBox.Size = new System.Drawing.Size(350, 41);
            this.groupTextBox.TabIndex = 8;
            this.groupTextBox.Texts = "";
            this.groupTextBox.UnderlinedStyle = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.nameTextBox.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.nameTextBox.BorderRadius = 1;
            this.nameTextBox.BorderSize = 1;
            this.nameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameTextBox.Location = new System.Drawing.Point(229, 150);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.PlaceholderText = "Имя Фамилия";
            this.nameTextBox.Size = new System.Drawing.Size(350, 41);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Texts = "";
            this.nameTextBox.UnderlinedStyle = true;
            this.nameTextBox._TextChanged += new System.EventHandler(this.nameTextBox__TextChanged);
            // 
            // GetPersonalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundCornerButton1);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GetPersonalDataForm";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.RoundCornerTextBox nameTextBox;
        private Controls.RoundCornerTextBox groupTextBox;
        private Controls.RoundCornerButton roundCornerButton1;
    }
}