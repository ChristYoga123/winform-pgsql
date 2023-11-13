using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPGSQL.App.Context;
using WinformPGSQL.App.Models;

namespace WinformPGSQL
{
    public partial class TambahMahasiswa : Form
    {
        public TambahMahasiswa()
        {
            InitializeComponent();
            // Looping untuk get Real Data dari DataTable
            DataTable dataProdi = ProdiContext.all();
            List<KeyValuePair<int, string>> prodi = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataProdi.Rows.Count; i++)
            {
                int idProdi = Convert.ToInt32(dataProdi.Rows[i]["id"]);
                string namaProdi = dataProdi.Rows[i]["nama_prodi"].ToString();

                prodi.Add(new KeyValuePair<int, string>(idProdi, namaProdi));
            }
            Prodi.DataSource = prodi;
            Prodi.ValueMember = "Key";
            Prodi.DisplayMember = "Value";

        }

        private void tambahSimpanButton_Click(object sender, EventArgs e)
        {
            var nama = Nama.Text;
            var nim = Nim.Text;
            // Mendapatkan item yang dipilih
            KeyValuePair<int, string> selectedProdi = (KeyValuePair<int, string>)Prodi.SelectedItem;
            var idProdi = selectedProdi.Key;

            // masukkan ke dalam Object seperti M_Mahasiswa
            M_Mahasiswa dataMahasiswaBaru = new M_Mahasiswa
            {
                nama = nama,
                nim = nim,
                prodi_id = idProdi
            };
            MahasiswaContext.store(dataMahasiswaBaru);
            DialogResult message = MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                // tutup form tambahMahasiswa
                this.Close();

            }
        }
    }
}
