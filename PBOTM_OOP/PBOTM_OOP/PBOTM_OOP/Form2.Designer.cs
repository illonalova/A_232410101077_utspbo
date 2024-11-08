namespace PBOTM_OOP
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNama = new TextBox();
            dttgllahir = new DateTimePicker();
            tbNIM = new TextBox();
            tbAlamat = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            tbProdi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 68);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 123);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 1;
            label2.Text = "NIM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 176);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Prodi";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 227);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Lahir";
            label4.Click += label4_Click;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(188, 68);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(483, 31);
            tbNama.TabIndex = 4;
            tbNama.TextChanged += textBox1_TextChanged;
            // 
            // dttgllahir
            // 
            dttgllahir.Location = new Point(188, 227);
            dttgllahir.Name = "dttgllahir";
            dttgllahir.Size = new Size(338, 31);
            dttgllahir.TabIndex = 5;
            // 
            // tbNIM
            // 
            tbNIM.Location = new Point(188, 120);
            tbNIM.Name = "tbNIM";
            tbNIM.Size = new Size(483, 31);
            tbNIM.TabIndex = 6;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(188, 281);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(483, 31);
            tbAlamat.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 284);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 9;
            label5.Text = "Alamat";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(663, 370);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(527, 370);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tbProdi
            // 
            tbProdi.Location = new Point(188, 173);
            tbProdi.Name = "tbProdi";
            tbProdi.Size = new Size(338, 31);
            tbProdi.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(tbProdi);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(tbAlamat);
            Controls.Add(tbNIM);
            Controls.Add(dttgllahir);
            Controls.Add(tbNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNama;
        private DateTimePicker dttgllahir;
        private TextBox tbNIM;
        private TextBox tbAlamat;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox tbProdi;
    }
}