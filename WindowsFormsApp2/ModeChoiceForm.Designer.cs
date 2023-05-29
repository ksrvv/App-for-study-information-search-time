namespace WindowsFormsApp2
{
    partial class ModeChoiceForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.roundCornerButton2 = new WindowsFormsApp2.Controls.RoundCornerButton();
            this.roundCornerButton1 = new WindowsFormsApp2.Controls.RoundCornerButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.label1.Size = new System.Drawing.Size(800, 311);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundCornerButton2
            // 
            this.roundCornerButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.roundCornerButton2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundCornerButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.roundCornerButton2.BorderRadius = 15;
            this.roundCornerButton2.BorderSize = 0;
            this.roundCornerButton2.FlatAppearance.BorderSize = 0;
            this.roundCornerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundCornerButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roundCornerButton2.ForeColor = System.Drawing.Color.White;
            this.roundCornerButton2.Location = new System.Drawing.Point(146, 343);
            this.roundCornerButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCornerButton2.Name = "roundCornerButton2";
            this.roundCornerButton2.Size = new System.Drawing.Size(206, 56);
            this.roundCornerButton2.TabIndex = 1;
            this.roundCornerButton2.Text = "Все результаты";
            this.roundCornerButton2.TextColor = System.Drawing.Color.White;
            this.roundCornerButton2.UseVisualStyleBackColor = false;
            this.roundCornerButton2.Click += new System.EventHandler(this.roundCornerButton2_Click);
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
            this.roundCornerButton1.Location = new System.Drawing.Point(445, 343);
            this.roundCornerButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCornerButton1.Name = "roundCornerButton1";
            this.roundCornerButton1.Size = new System.Drawing.Size(206, 56);
            this.roundCornerButton1.TabIndex = 0;
            this.roundCornerButton1.Text = "Пройти тест";
            this.roundCornerButton1.TextColor = System.Drawing.Color.White;
            this.roundCornerButton1.UseVisualStyleBackColor = false;
            this.roundCornerButton1.Click += new System.EventHandler(this.roundCornerButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundCornerButton2);
            this.Controls.Add(this.roundCornerButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundCornerButton roundCornerButton1;
        private Controls.RoundCornerButton roundCornerButton2;
        private System.Windows.Forms.Label label1;
    }
}

