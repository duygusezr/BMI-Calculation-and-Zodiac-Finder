namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox9 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            listBox7 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            textBox2 = new TextBox();
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(17, 60);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 1;
            label1.Text = "Doğum Tarihi";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(75, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 256);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 11);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 18;
            label2.Text = "Öğrenci Bilgileri";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(116, 211);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 23);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(116, 171);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(131, 23);
            textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(116, 130);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(131, 23);
            textBox8.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(76, 214);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 14;
            label6.Text = "Kilo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(77, 173);
            label7.Name = "label7";
            label7.Size = new Size(31, 17);
            label7.TabIndex = 13;
            label7.Text = "Boy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(61, 132);
            label8.Name = "label8";
            label8.Size = new Size(49, 17);
            label8.TabIndex = 12;
            label8.Text = "Soyadı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(81, 99);
            label9.Name = "label9";
            label9.Size = new Size(29, 17);
            label9.TabIndex = 11;
            label9.Text = "Adı";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(116, 97);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(131, 23);
            textBox9.TabIndex = 10;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(136, 317);
            button1.Name = "button1";
            button1.Size = new Size(123, 59);
            button1.TabIndex = 11;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(418, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(97, 319);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(521, 37);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(97, 319);
            listBox2.TabIndex = 13;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(624, 37);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(97, 319);
            listBox3.TabIndex = 15;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(728, 37);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(97, 319);
            listBox4.TabIndex = 14;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(831, 37);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(97, 319);
            listBox5.TabIndex = 17;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(934, 37);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(97, 319);
            listBox6.TabIndex = 16;
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.ItemHeight = 15;
            listBox7.Location = new Point(1037, 37);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(97, 319);
            listBox7.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(448, 17);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 19;
            label3.Text = "Adı";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(548, 17);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 20;
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(548, 17);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 21;
            label5.Text = "Soyadı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(660, 17);
            label10.Name = "label10";
            label10.Size = new Size(33, 17);
            label10.TabIndex = 22;
            label10.Text = "Gün";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(754, 17);
            label11.Name = "label11";
            label11.Size = new Size(49, 17);
            label11.TabIndex = 23;
            label11.Text = "Ay Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(866, 17);
            label12.Name = "label12";
            label12.Size = new Size(24, 17);
            label12.TabIndex = 24;
            label12.Text = "Yıl";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(968, 17);
            label13.Name = "label13";
            label13.Size = new Size(29, 17);
            label13.TabIndex = 25;
            label13.Text = "VKİ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(1067, 17);
            label14.Name = "label14";
            label14.Size = new Size(35, 17);
            label14.TabIndex = 26;
            label14.Text = "Burç";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Yengec;
            pictureBox1.Location = new Point(422, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(422, 383);
            label15.Name = "label15";
            label15.Size = new Size(76, 17);
            label15.TabIndex = 28;
            label15.Text = "Burç Resmi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(713, 441);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 23);
            textBox2.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(713, 421);
            label16.Name = "label16";
            label16.Size = new Size(48, 17);
            label16.TabIndex = 30;
            label16.Text = "Yorum";
            label16.Click += label16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1191, 660);
            Controls.Add(label16);
            Controls.Add(textBox2);
            Controls.Add(label15);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox7);
            Controls.Add(listBox5);
            Controls.Add(listBox6);
            Controls.Add(listBox3);
            Controls.Add(listBox4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            Text = "Öğrenci Bilgileri";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox9;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox1;
        private Label label15;
        private TextBox textBox2;
        private Label label16;
    }
}
