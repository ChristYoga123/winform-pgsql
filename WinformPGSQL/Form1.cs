using WinformPGSQL.App.Context;

namespace WinformPGSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabelMahasiswa.DataSource = MahasiswaContext.all();
            // Modifikasi datagridview
            DataGridViewButtonColumn ubahButton = new DataGridViewButtonColumn();
            ubahButton.HeaderText = "Ubah";
            ubahButton.Text = "Update";
            ubahButton.Name = "ubahButton";
            ubahButton.UseColumnTextForButtonValue = true;
            tabelMahasiswa.Columns.Insert(0, ubahButton);

            DataGridViewButtonColumn hapusButton = new DataGridViewButtonColumn();
            hapusButton.HeaderText = "Hapus";
            hapusButton.Text = "Delete";
            hapusButton.Name = "hapusButton";
            hapusButton.UseColumnTextForButtonValue = true;
            tabelMahasiswa.Columns.Insert(1, hapusButton);
        }

        private void tambahButton_Click(object sender, EventArgs e)
        {
            using (TambahMahasiswa tambahMahasiswaForm = new TambahMahasiswa())
            {
                TambahMahasiswa halamanTambahMahasiswa = new TambahMahasiswa();
                halamanTambahMahasiswa.ShowDialog();
            }
            tabelMahasiswa.DataSource = null;
            tabelMahasiswa.DataSource = MahasiswaContext.all();
        }

        private void tabelMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelMahasiswa.Columns["hapusButton"].Index && e.RowIndex >= 0)
            {
                // Menyusun kode yang akan dijalankan saat tombol "Hapus" diklik
                // Anda bisa menggunakan e.RowIndex untuk mengidentifikasi baris yang diklik.
                // Misalnya, Anda dapat mengambil ID dari baris yang diklik dan kemudian menghapusnya dari data.

                int idMahasiswaHapus = Convert.ToInt32(tabelMahasiswa.Rows[e.RowIndex].Cells["id"].Value);

                // Panggil metode destroy dari kelas M_Mahasiswa untuk menghapus mahasiswa tetapi konfirmasi dulu
                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    MahasiswaContext.destroy(idMahasiswaHapus);
                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                }

                // Kemudian, perbarui DataGridView dengan data yang telah diperbarui
                tabelMahasiswa.DataSource = null;
                tabelMahasiswa.DataSource = MahasiswaContext.all();
            }

            if (e.ColumnIndex == tabelMahasiswa.Columns["ubahButton"].Index && e.RowIndex >= 0)
            {
                // Menyusun kode yang akan dijalankan saat tombol "Hapus" diklik
                // Anda bisa menggunakan e.RowIndex untuk mengidentifikasi baris yang diklik.
                // Misalnya, Anda dapat mengambil ID dari baris yang diklik dan kemudian menghapusnya dari data.

                int idMahasiswaUbah = Convert.ToInt32(tabelMahasiswa.Rows[e.RowIndex].Cells["id"].Value);

                using (EditMahasiswa editMahasiswaForm = new EditMahasiswa(idMahasiswaUbah))
                {
                    EditMahasiswa halamanEditMahasiswa = new EditMahasiswa(idMahasiswaUbah);
                    halamanEditMahasiswa.ShowDialog();
                }
                tabelMahasiswa.DataSource = null;
                tabelMahasiswa.DataSource = MahasiswaContext.all();
            }
        }
    }
}