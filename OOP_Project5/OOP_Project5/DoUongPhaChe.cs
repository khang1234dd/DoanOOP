using System;
using System.Collections.Generic;

namespace OOP_Project5
{
    public class DoUongPhaChe : DoUong
    {

        public override string thongTinDoUong()
        {
            return "Ten Do Uong Pha Che: " + tendouong + "\n"+"Loai Do Uong: " + loaidouong  + "\n" + "Gia ban dau do uong Pha Che: " + giaBanDau + "\n" + "Gia ban ra do uong Pha Che: "+ giaBanRa + "\n" + "Han Su Dung: " + hansudung + "\n"  + "Trang thai: " +trangThai() + "\n";
        }

        public override string trangThai()
        {
            bool ktnl = kiemtraNguyenLieu();
            if(ktnl == true)
            {
                return "Co the pha che";
            }
            return "khong du nguyen lieu pha che";
        }

        public bool kiemtraNguyenLieu()
        {
            int tongsoluongnl= 0;
            int tongsoluongdu = 0;
            bool kt = false;
            foreach (NguyenLieu item in dtb.dsNguyenLieu)
            {
                tongsoluongnl = tongsoluongnl + item.soLuong;
            }
            foreach (DoUong item in dtb.dsDoUong)
            {
                tongsoluongdu = tongsoluongdu + item.soluong;
            }

            if (tongsoluongnl >= (tongsoluongdu+1)*3)
            {
                kt = true;
                return kt;
            }
            return kt;
        }
        public DoUongPhaChe()
        {
            this.tendouong = "";
            this.loaidouong = "Pha Che";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.hansudung = DateTime.Now;
           // this.trangthai = "";
        }

        public DoUongPhaChe(DoUong douong)
        {
            this.tendouong = "";
            this.loaidouong = "Pha Che";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.hansudung = DateTime.Now;
         //   this.trangthai = "";
        }
        public DoUongPhaChe(string tendouong, int giabandau, int giaBanRa, DateTime hansudung, string trangthai,Database dtb)
        {
            this.tendouong = tendouong;
            this.loaidouong = "Pha Che";
            this.giaBanDau = giabandau;
            this.giaBanRa = giaBanRa;
            this.hansudung = hansudung;
           // this.trangthai = trangthai;
            this.dtb = new Database();
            this.dtb = dtb;
        }

        public DoUongPhaChe(string tendouong, int giabandau, int giabanra, int soluong, Database dtb)
        {
            this.tendouong = tendouong;
            this.loaidouong = "Pha Che";
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.soluong = soluong;
            this.dtb = new Database();
            this.dtb = dtb;
        }
    }
}
