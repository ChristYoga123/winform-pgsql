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
    public partial class EditMahasiswa : Form
    {
        int idMahasiswa;
        public EditMahasiswa(int id)
        {
            this.idMahasiswa = id;
            InitializeComponent();
            // init data Mahasiswa
            DataTable dataMahasiswa = MahasiswaContext.show(id);
            Nama.Text = dataMahasiswa.Rows[0]["nama"].ToString();
            Nim.Text = dataMahasiswa.Rows[0]["nim"].ToString();

            // init data Prodi
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

        private void ubahSimpanButton_Click(object sender, EventArgs e)
        {
            var nama = Nama.Text;
            var nim = Nim.Text;
            // Mendapatkan item yang dipilih
            KeyValuePair<int, string> selectedProdi = (KeyValuePair<int, string>)Prodi.SelectedItem;
            var idProdi = selectedProdi.Key;

            // masukkan ke dalam Object seperti M_Mahasiswa
            M_Mahasiswa dataMahasiswaUpdate = new M_Mahasiswa
            {
                id = this.idMahasiswa,
                nama = nama,
                nim = nim,
                prodi_id = idProdi
            };
            MahasiswaContext.update(dataMahasiswaUpdate);
            DialogResult message = MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                // tutup form tambahMahasiswa
                this.Close();

            }
        }
    }
}
