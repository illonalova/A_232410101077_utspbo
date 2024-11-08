using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBOTM_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //object[] dataProdi = new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" };
            //cbProdi.Items.AddRange(dataProdi);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Mahasiswa GetMahasiswa()
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nim = tbNIM.Text;
            mhs.Nama = tbNama.Text;
            mhs.Prodi = tbProdi.Text;
            mhs.Tanggal_lahir = DateOnly.Parse(dttgllahir.Value.ToShortDateString());
            mhs.Alamat = tbAlamat.Text;

            return mhs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// Misalnya, kita memiliki TextBox dan ComboBox
            //tbNama.Text = string.Empty;
            //tbNIM.Text = string.Empty;
            //tbAlamat.Text = string.Empty;
            //tbProdi.Text = string.Empty;
            //dttgllahir.SelectedIndex = -1; // Mengatur ComboBox ke pilihan kosong

            //// Jika ada kontrol lain yang ingin Anda reset, lakukan hal yang sama
            //// Misalnya, untuk DateTimePicker
            //dttgllahir.Value = DateOnly.Today; // Mengatur ke tanggal saat ini

            //// Reset data lainnya sesuai kebutuhan Anda.
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbProdi.FormatingEnabled = true;
        //    cbProdi.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
        //    cbProdi.Location = new Point(187, 233);
        //    cbProdi.Name = ""
        //}
    }
}
