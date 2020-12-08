using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_098.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }



        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }


        [Required(ErrorMessage = "No Polisi wajib diisi")]
        public string NoPolisi { get; set; }



        [Required(ErrorMessage = "No STNK wajib diisi")]
        [MinLength(7, ErrorMessage = "No STNK tidak boleh kurang dari 7")]
        [MaxLength(8, ErrorMessage = "No STNK tidak boleh lebih dari 8")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }


        [Required(ErrorMessage = "Ketersediaan wajib diisi")]
        public string Ketersediaan { get; set; }
        public int? IdJenisKendaraan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
