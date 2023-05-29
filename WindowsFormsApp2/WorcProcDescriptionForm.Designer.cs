namespace WindowsFormsApp2
{
    partial class WorcProcDescriptionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.roundCornerButton1 = new WindowsFormsApp2.Controls.RoundCornerButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(0, 144);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(90, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(1076, 334);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(90, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(1076, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "Процедура опыта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(504, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "2/2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(86, 519);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(286, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "С описанием работы ознакомлен(а)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
            this.checkBox1.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
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
            this.roundCornerButton1.Location = new System.Drawing.Point(814, 498);
            this.roundCornerButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCornerButton1.Name = "roundCornerButton1";
            this.roundCornerButton1.Size = new System.Drawing.Size(188, 50);
            this.roundCornerButton1.TabIndex = 6;
            this.roundCornerButton1.Text = "Регистрация";
            this.roundCornerButton1.TextColor = System.Drawing.Color.White;
            this.roundCornerButton1.UseVisualStyleBackColor = false;
            this.roundCornerButton1.Click += new System.EventHandler(this.roundCornerButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1076, 590);
            this.Controls.Add(this.roundCornerButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private Controls.RoundCornerButton roundCornerButton1;
    }
}