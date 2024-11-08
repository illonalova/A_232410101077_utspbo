using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBOTM_OOP
{
    public partial class Form1 : Form
    {
        List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>();

        public Form1()
        {
            InitializeComponent();

            //Object[.]objmhs = { "1021", "Dhira", "Jl. Imam Bonjol 261", new DateTime(2005,03, 29), "SI"};

            //for(int i=0 < objmhs.GetLength(a); 

            Mahasiswa mhs = new Mahasiswa
            {
                Nim = "1021",
                Nama = "Dhira",
                Alamat = "Jl. Imam Bonjol 261",
                Tanggal_lahir = new DateOnly(2005, 03, 29),
                Prodi = "SI"
            };

            ListMahasiswa.Add(mhs);

            // Binding ListMahasiswa ke DataGridView
            dataGridView1.DataSource = ListMahasiswa;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler kosong
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmDataBaru = new Form2();
            if (frmDataBaru.ShowDialog() == DialogResult.OK);
            {
                Mahasiswa mhs2 = frmDataBaru.GetMahasiswa();
                ListMahasiswa.Add(mhs2);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListMahasiswa;
            }
        }
    }

    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public DateOnly Tanggal_lahir { get; set; }
        public string Prodi { get; set; }
    }
}
