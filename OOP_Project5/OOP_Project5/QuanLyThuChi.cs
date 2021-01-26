using System;
using System.Collections.Generic;

namespace OOP_Project5
{
    public class QuanLyThuChi
    {
        // thuoc tinh
        public string tennguoiphutrach { set; get; }
        public List<DoUong> dsDoUong { set; get; }
        Database dtb;
        public QuanLyThuChi()
        {
            tennguoiphutrach = "";
            dsDoUong = new List<DoUong>();
            dtb = new Database();
        }
        public QuanLyThuChi(Database dtb)
        {
            tennguoiphutrach = "";
            this.dtb = new Database();
            this.dtb = dtb;
            this.dsDoUong = new List<DoUong>();
        }
        public int tongThu()
        {
            int kq = 0;
            foreach (DoUong item in dsDoUong)
            {
                kq = kq + (item.giaBanRa * item.soluongdaban);
            }
            return kq;
        }
        public int tongChi()
        {
            int kq = 0;
            foreach (DoUong item in dsDoUong)
            {
                kq = kq + (item.giaBanDau * item.soluong);
            }
            return kq;
        }
        public string tinhLoiLo()
        {
            int thu = tongThu();
            int chi = tongChi();
            int hieu = thu - chi;
            if (hieu > 0)
                return "Tien loi: " + hieu;
            else if( hieu ==0)
            {
                return "Hue von";
            }
            else
            {
                hieu=-hieu;
                return "Tien Lo: " + hieu; 
            }
        }
        public string layDuLieuDatabase()
        {
            dtb.truyvanEvent += Dtb_truyvanEvent;
            return (string)dtb.truyVan();
        }

        private object Dtb_truyvanEvent(params object[] thamso)
        {
            foreach(DoUong item in dtb.dsDoUong)
            {
                dsDoUong.Add(item);
            }
            return "Lay du lieu thanh cong";
        }
    }
}
