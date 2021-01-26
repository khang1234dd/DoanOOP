using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project5
{
    public class DoUongCoGas : DoUong
    {

        public override string thongTinDoUong()
        {
            return "Ten Do Uong Co Gas: " + tendouong + "\n" + "Loai Do Uong: " + loaidouong + "\n" + "Gia ban dau do uong Co Gas: " + giaBanDau + "\n" + "Gia ban ra do uong Co Gas:" + giaBanRa + "\n" + "Han Su Dung: " + hansudung + "\n" + "Trang thai: " + trangThai() + "\n";
        }

        public override string trangThai()
        {
            foreach (DoUong item in dtb.dsDoUong)
            {
                if (item == this)
                {
                    return "Ton tai";
                }
            }
            return "Khong ton tai";
        }

        public DoUongCoGas()
        {
            this.tendouong = "";
            this.loaidouong = "Co Gas";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.hansudung = DateTime.Now;
            //this.trangthai = "";
        }

        public DoUongCoGas(DoUong douong)
        {
            this.tendouong = "";
            this.loaidouong = "Co Gas";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.hansudung = DateTime.Now;
            //this.trangthai = "";
        }
        public DoUongCoGas(string tendouong, int giabandau,int giabanra, DateTime hansudung, string trangthai,Database dtb)
        {
            this.tendouong = tendouong;
            this.loaidouong = "Co Gas";
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.hansudung = hansudung;
           // this.trangthai = trangthai;
            this.dtb = new Database();
            this.dtb = dtb;
        }
        public DoUongCoGas(string tendouong, int giabandau, int giabanra, int soluong, Database dtb)
        {
            this.tendouong = tendouong;
            this.loaidouong = "Co Gas";
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.soluong = soluong;
            this.dtb = new Database();
            this.dtb = dtb;
        }
    }
}
