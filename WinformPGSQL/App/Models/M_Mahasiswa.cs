using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformPGSQL.App.Models
{
    internal class M_Mahasiswa
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        public string nim { get; set; }
        [ForeignKey("M_Prodi")]
        public int prodi_id { get; set; }
    }
}
