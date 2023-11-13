using WinformPGSQL.App.Context;

namespace WinformPGSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabelMahasiswa.DataSource = MahasiswaContext.all();
        }
    }
}