namespace Maket
{
    partial class Form_Enter
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
            this.label3 = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите Пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите Пароль";
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_btn.ForeColor = System.Drawing.Color.Maroon;
            this.enter_btn.Location = new System.Drawing.Point(324, 292);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(121, 49);
            this.enter_btn.TabIndex = 3;
            this.enter_btn.Text = "Вход";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "АДМИН",
            "ВОДИТЕЛЬ"});
            this.comboBox1.Location = new System.Drawing.Point(324, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_txt.Location = new System.Drawing.Point(324, 212);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(155, 30);
            this.password_txt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(32)))), ((int)(((byte)(124)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(630, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(80, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(602, 57);
            this.label44.TabIndex = 44;
            this.label44.Text = "АИС АВТОБУСНЫЙ ПАРК";
            // 
            // Form_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maket.Properties.Resources._33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_Enter";
            this.Text = "АИС Автобусный парк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label44;
    }
}