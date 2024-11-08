using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_232410101077_utspbo
{
    public partial class Halaman_Kontak : Form
    {
        public Halaman_Kontak()
        {
                InitializeComponent();

                 mhs = new Mahasiswa
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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
       
}
