namespace WindowsFormsApp2
{
    partial class ResultsFrom
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
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roundCornerButton2 = new WindowsFormsApp2.Controls.RoundCornerButton();
            this.roundCornerButton1 = new WindowsFormsApp2.Controls.RoundCornerButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(66, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Вернуться на главную";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выполнить еще одну тестовую серию";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(67, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Количество предъявлений:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(389, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество предъявлений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(389, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество индикаторов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(67, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 28);
            this.label10.TabIndex = 15;
            this.label10.Text = "Количество индикаторов: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(577, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Общее среднее ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(67, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(458, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Общее среднее экспериментальное значение:";
            // 
            // roundCornerButton2
            // 
            this.roundCornerButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.roundCornerButton2.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.roundCornerButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.roundCornerButton2.BorderRadius = 15;
            this.roundCornerButton2.BorderSize = 0;
            this.roundCornerButton2.FlatAppearance.BorderSize = 0;
            this.roundCornerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundCornerButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roundCornerButton2.ForeColor = System.Drawing.Color.White;
            this.roundCornerButton2.Location = new System.Drawing.Point(727, 510);
            this.roundCornerButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCornerButton2.Name = "roundCornerButton2";
            this.roundCornerButton2.Size = new System.Drawing.Size(210, 50);
            this.roundCornerButton2.TabIndex = 28;
            this.roundCornerButton2.Text = "Визуализировать";
            this.roundCornerButton2.TextColor = System.Drawing.Color.White;
            this.roundCornerButton2.UseVisualStyleBackColor = false;
            this.roundCornerButton2.Click += new System.EventHandler(this.roundCornerButton2_Click);
            this.roundCornerButton2.MouseEnter += new System.EventHandler(this.roundCornerButton2_MouseEnter);
            this.roundCornerButton2.MouseLeave += new System.EventHandler(this.roundCornerButton2_MouseLeave);
            // 
            // roundCornerButton1
            // 
            this.roundCornerButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundCornerButton1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundCornerButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.roundCornerButton1.BorderRadius = 15;
            this.roundCornerButton1.BorderSize = 0;
            this.roundCornerButton1.FlatAppearance.BorderSize = 0;
            this.roundCornerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundCornerButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roundCornerButton1.ForeColor = System.Drawing.Color.White;
            this.roundCornerButton1.Location = new System.Drawing.Point(169, 510);
            this.roundCornerButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCornerButton1.Name = "roundCornerButton1";
            this.roundCornerButton1.Size = new System.Drawing.Size(210, 50);
            this.roundCornerButton1.TabIndex = 27;
            this.roundCornerButton1.Text = "Скачать результаты";
            this.roundCornerButton1.TextColor = System.Drawing.Color.White;
            this.roundCornerButton1.UseVisualStyleBackColor = false;
            this.roundCornerButton1.Click += new System.EventHandler(this.roundCornerButton1_Click);
            this.roundCornerButton1.MouseEnter += new System.EventHandler(this.roundCornerButton1_MouseEnter);
            this.roundCornerButton1.MouseLeave += new System.EventHandler(this.roundCornerButton1_MouseLeave);
            // 
            // ResultsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1038, 633);
            this.Controls.Add(this.roundCornerButton2);
            this.Controls.Add(this.roundCornerButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResultsFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form8_FormClosed);
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Controls.RoundCornerButton roundCornerButton2;
        private Controls.RoundCornerButton roundCornerButton1;
    }
}