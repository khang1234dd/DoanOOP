using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project5
{
    public class DoUongBoSung : DoUong
    {
        //string trangthaidubs;
        public override string thongTinDoUong()
        {
            return "Ten Do Uong Bo Sung: " + tendouong + "\n" + "Loai Do Uong: " + loaidouong  + "\n" + "Gia ban dau do uong Bo Sung: " + giaBanDau + "\n" + "Gia ban ra do uong Bo Sung: " + giaBanRa + "\n" + "Han Su Dung: " + hansudung + "\n" + "Trang thai: " + trangThai() + "\n";
        }

        public override string trangThai()
        {
            foreach(DoUong item in dsDoUong)
            {
                if(item == this)
                {
                    return "Ton tai";
                }
            }
            return "Khong ton tai";
        }

        public DoUongBoSung()
        {
            this.tendouong = "";
            this.loaidouong = "Bo Sung";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.hansudung = DateTime.Now;
            //this.trangthai = "";
            //dsDoUong = new List<string>();
        }

        public DoUongBoSung(DoUong douong)
        {
            this.tendouong = "";
            this.loaidouong = "Bo Sung";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.hansudung = DateTime.Now;
            //this.trangthai = "";
            //dsDoUongBoSung = new List<string>();
        }
        public DoUongBoSung(string tendouong, int giabandau,int giabanra, DateTime hansudung, string trangthai,Database dtb)
        {
            this.tendouong = tendouong;
            this.loaidouong = "Bo Sung";
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.hansudung = hansudung;
            //this.trangthai = trangthai;
            this.dtb = new Database();
            this.dtb = dtb;
            // this.dsDoUongBoSung = dsdouongbosung;
        }
        public DoUongBoSung(string tendouong, int giabandau, int giabanra, int soluong, Database dtb)
        {
            this.tendouong = tendouong;
            this.loaidouong = "Bo Sung";
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.soluong = soluong;
            this.dtb = new Database();
            this.dtb = dtb;
        }
    }
}
