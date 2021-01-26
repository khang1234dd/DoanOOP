using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project5
{
    public abstract class DoUong
    {
        //thuoc tinh
        public static int idx;
        public static string iddouong { set; get; }
        public string tendouong { set; get; }
        public string loaidouong { set; get; }
        public int soluong { set; get; }
        public int soluongdaban { set; get; }
        public int giaBanDau { set; get; }
        public int giaBanRa { set; get; }
        public DateTime hansudung { set; get; }
        public string trangthai { get; }

        protected List<DoUong> dsDoUong { set; get; }

        public Database dtb;

        // ham static
        static DoUong()
        {
            idx = 0;
            iddouong = "du" + idx;
        }

        //ham dung khong tham so
        public DoUong()
        {
            idx++;
            iddouong = "du" + idx.ToString();
            this.tendouong = "";
            this.loaidouong = "";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.soluong = 0;
            this.soluongdaban = 0;
            this.hansudung = DateTime.Now;
            this.trangthai = "";
            dtb = new Database();
            dsDoUong = new List<DoUong>();

        }

        //ham dung co tham so truyen
        public DoUong (string tendouong,int giabandau,int giabanra,int soluong,Database dtb)
        {
            idx++;
            iddouong = "du" + idx.ToString();
            this.tendouong = tendouong;
            this.loaidouong = "";
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.soluong = soluong;
            this.soluongdaban = 0;
            this.hansudung = DateTime.Now;
            this.trangthai = "";
            this.dtb = new Database();
            this.dtb = dtb;
            dsDoUong = new List<DoUong>();
        }
        public DoUong(string tendouong, string loaidouong, int giabandau,int giabanra,int soluong,int soluongdaban, DateTime hansudung, string trangthai,Database dtb, List<DoUong> dsdouong)
        {
            idx++;
            iddouong = "du" + idx.ToString();
            this.tendouong = tendouong;
            this.loaidouong = loaidouong;
            this.giaBanDau = giabandau;
            this.giaBanRa = giabanra;
            this.soluong = soluong;
            this.soluongdaban = soluongdaban;
            this.hansudung = hansudung;
            this.trangthai = trangthai;
            dsDoUong = new List<DoUong>();
            this.dtb = new Database();
            this.dtb = dtb;
            foreach(DoUong item in dsdouong)
            {
                dsDoUong.Add(item);
            }
        }
        //ham khoi tao cung kieu
        public DoUong(DoUong douong)
        {
            idx++;
            iddouong = "du" + idx.ToString();
            this.tendouong = "";
            this.loaidouong = "";
            this.giaBanDau = 0;
            this.giaBanRa = 0;
            this.soluong = 0;
            this.soluongdaban = 0;
            this.hansudung = DateTime.Now;
            this.trangthai = "";
            dtb = new Database();
            dsDoUong = new List<DoUong>();
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
                dsDoUong.Add(item) ;
            }
            return "Lay du lieu thanh cong";
        }


        // phuong thuc
        public static DoUong operator +(DoUong douong1, DoUong douong2)
        {
            //kq.savelevel = 0;
            if((douong1.GetType() == typeof(DoUongCoGas) && douong2.GetType() == typeof(DoUongBoSung)) 
                || (douong1.GetType() == typeof(DoUongBoSung) && douong2.GetType() == typeof(DoUongCoGas)))
            {
                DoUong kq = new DoUongPhaChe();
                return kq;
            }
            if ((douong1.GetType() == typeof(DoUongCoGas) && douong2.GetType() == typeof(DoUongPhaChe))
                || (douong1.GetType() == typeof(DoUongPhaChe) && douong2.GetType() == typeof(DoUongCoGas)))
            {
                DoUong kq = new DoUongBoSung();
                return kq;
            }
            if ((douong1.GetType() == typeof(DoUongBoSung) && douong2.GetType() == typeof(DoUongPhaChe))
                || (douong1.GetType() == typeof(DoUongPhaChe) && douong2.GetType() == typeof(DoUongBoSung)))
            {
                DoUong kq = new DoUongCoGas();
                return kq;
            }
            return null;
        }

        public abstract string thongTinDoUong();
        public abstract string trangThai();
    }
}
