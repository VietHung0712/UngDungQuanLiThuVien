using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_quản_lý_thư_viện.Models
{
    public class SACH
    {
        public int Id { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public int NXB { get; set; }
        public float GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string AnhSach { get; set; }

        public SACH() { }
        public SACH(int id, string tenSach, string tacGia, string theLoai, int nXB, float giaBan, int soLuong, string anhSach)
        {
            Id = id;
            TenSach = tenSach;
            TacGia = tacGia;
            TheLoai = theLoai;
            NXB = nXB;
            GiaBan = giaBan;
            SoLuong = soLuong;
            AnhSach = anhSach;
        }

        ~SACH() { }
    }
}
