using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_098.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }


        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }


        [RegularExpression("^[0-9]*$", ErrorMessage = "NIK hannya boleh di isi angka")]
        public string Nik { get; set; }


        [Required(ErrorMessage = "Alamat wajib di isi")]
        public string Alamat { get; set; }
        
        
        
        [MinLength(10, ErrorMessage = " No hp minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No hp maksimal 13 angka")]

        [Required(ErrorMessage = " No HP wajib di isi")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
