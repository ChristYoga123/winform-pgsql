using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformPGSQL.App.Models
{
    internal class M_Prodi
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama_prodi { get; set; }
    }
}
