using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project5
{
    public class NhanVien
    {
        //thuoc tinh
        public string maNhanVien { set; get; }
        public string hoTen { set; get; }
        public DateTime ngayBatDauHopDong  { set; get; }
        public string anhDaiDien { set; get; }
        public string vitriDamNhiem { set; get; }
        public string thaidoPhucVu { set; get; }
        Database dtb;

        public NhanVien()
        {
            maNhanVien = "";
            hoTen = "";
            ngayBatDauHopDong = DateTime.Now;
            anhDaiDien = "";
            vitriDamNhiem = "";
            thaidoPhucVu = "";
            dtb = new Database();
        }
        public NhanVien(string manhanvien,string hoten, DateTime ngaybatdauhopdong, string anhdaidien
            , string vitridamnhiem, string thaidophucvu,Database dtb)
        {
            this.maNhanVien = manhanvien;
            this.hoTen = hoten;
            this.ngayBatDauHopDong = ngaybatdauhopdong;
            this.anhDaiDien = anhdaidien;
            this.vitriDamNhiem = vitridamnhiem;
            this.thaidoPhucVu = thaidophucvu;
            this.dtb = new Database();
            this.dtb = dtb;
        }
    }
}
