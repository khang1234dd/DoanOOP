using System;
using System.Collections.Generic;

namespace OOP_Project5
{
    public class NguyenLieu
    {
        //thuoc tinh
        public static int idx;
        public static string idNguyenLieu { set; get; }
        public string tenNguyenLieu { set; get; }
        public int soLuong { set; get; }
        public int donGia { set; get; }
        public DateTime ngayNhapHang { set; get; }
        public DateTime hansudung { set; get; }

        List<NguyenLieu> dsNguyenLieu { set; get; }
        Database dtb;


        //phuong thuc
        public string kiemtraNguyenLieu()
        {
            string kt = "Nguyen lieu khong ton tai";
            foreach (NguyenLieu item in dtb.dsNguyenLieu)
            {
                if (item == this)
                {
                    kt = "Nguyen lieu" +" "+ item.tenNguyenLieu +" " + "ton tai";
                }
            }
            return kt;
        }
        //ham static chi goi ra 1 lan khi khoi tao doi tuong dung lam khoi tao gia tri id nguyen lieu
        static NguyenLieu()
        {
            idx = 0;
            idNguyenLieu = "nl" + idx.ToString();
        }

        //ham dung khong tham so
        public NguyenLieu()
        {
            idx++;
            idNguyenLieu = "nl" + idx.ToString();
            tenNguyenLieu = "";
            soLuong = 0;
            donGia = 0;
            ngayNhapHang = DateTime.Now;
            hansudung = DateTime.Now;
            dtb = new Database();
            this.dsNguyenLieu = new List<NguyenLieu>();
        }
        public NguyenLieu(string tennguyenlieu, int soluong,Database dtb)
        {
            idx++;
            idNguyenLieu = "nl" + idx.ToString();
            this.tenNguyenLieu = tennguyenlieu;
            this.soLuong = soluong;
            donGia = 0;
            ngayNhapHang = DateTime.Now;
            hansudung = DateTime.Now;
            this.dtb = new Database();
            this.dtb = dtb;
            this.dsNguyenLieu = new List<NguyenLieu>();
        }
        //ham dung co tham so
        public NguyenLieu(string tennguyenlieu, int soluong, int dongia, DateTime ngaynhaphang, DateTime hansudung,Database dtb)
        {
            idx++;
            idNguyenLieu = "nl" + idx.ToString();
            this.tenNguyenLieu = tennguyenlieu;
            this.soLuong = soluong;
            this.donGia = dongia;
            this.ngayNhapHang = ngaynhaphang;
            this.hansudung = hansudung;
            this.dtb = new Database();
            this.dtb = dtb;
            this.dsNguyenLieu = new List<NguyenLieu>();
        }
        // phuong thuc
        public string layDuLieuTuDatabase()
        {
            dtb.truyvanEvent += Dtb_truyvanEvent;
            return (string)dtb.truyVan();
        }

        private object Dtb_truyvanEvent(params object[] thamso)
        {
            foreach(NguyenLieu item in dtb.dsNguyenLieu)
            {
                dsNguyenLieu.Add(item);
            }
            return "Lay du lieu thanh cong";
        }
    }
}
