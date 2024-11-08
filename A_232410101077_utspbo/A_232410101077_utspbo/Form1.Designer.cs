namespace A_232410101077_utspbo
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("STFangsong", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 31);
            label1.Name = "label1";
            label1.Size = new Size(208, 40);
            label1.TabIndex = 0;
            label1.Text = "Contact App";
            // 
            // button1
            // 
            button1.Location = new Point(89, 159);
            button1.Name = "button1";
            button1.Size = new Size(192, 34);
            button1.TabIndex = 2;
            button1.Text = "Halaman Kontak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(89, 213);
            button2.Name = "button2";
            button2.Size = new Size(192, 34);
            button2.TabIndex = 3;
            button2.Text = "Halaman Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(89, 268);
            button3.Name = "button3";
            button3.Size = new Size(192, 34);
            button3.TabIndex = 4;
            button3.Text = "Halaman Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 105);
            label2.Name = "label2";
            label2.Size = new Size(343, 32);
            label2.TabIndex = 5;
            label2.Text = "Pilih Salah Satu Dibawah Ini:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
