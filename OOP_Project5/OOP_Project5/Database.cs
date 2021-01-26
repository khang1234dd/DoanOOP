using System.Collections.Generic;

namespace OOP_Project5
{
    public class Database
    {
        public enum KieuDatabase
        {
            SQLServer,
            MySQL,
            MongoDB
        }
        public string tendatabase { set; get; }
        public string tentable { set; get; }
        public string chuoiketnoi { set; get; }
        public List<DoUong> dsDoUong { set; get; }
        public List<NguyenLieu> dsNguyenLieu { set; get; }
        public List<NhanVien> dsNhanVien { set; get; }

        // public List<>
        KieuDatabase kieudatabase;
        public Database()
        {
            tendatabase = "";
            tentable = "";
            chuoiketnoi = "";
            dsDoUong = new List<DoUong>();
            dsNguyenLieu = new List<NguyenLieu>();
            dsNhanVien = new List<NhanVien>();
            kieudatabase = 0; //SQLSever

        }
        public Database(List<DoUong> dsdouong)
        {
            tendatabase = "";
            tentable = "";
            chuoiketnoi = "";
            dsDoUong = new List<DoUong>();
            dsNguyenLieu = new List<NguyenLieu>();
            dsNhanVien = new List<NhanVien>();
            foreach (var item in dsdouong)
            {
                dsDoUong.Add(item);
            }
        }
        public Database(string tendatabase, string tentable, string chuoiketnoi, List<DoUong> dsdouong,
            List<NguyenLieu> dsnguyenlieu, List<NhanVien> dsnhanvien, KieuDatabase kieudatabase)
        {
            this.tendatabase = tendatabase;
            this.tentable = tentable;
            this.chuoiketnoi = chuoiketnoi;
            this.kieudatabase = kieudatabase;

            dsDoUong = new List<DoUong>();
            dsNguyenLieu = new List<NguyenLieu>();
            dsNhanVien = new List<NhanVien>();
            foreach (var item in dsdouong)
            {
                dsDoUong.Add(item);
            }
            foreach (var item in dsnhanvien)
            {
                dsNhanVien.Add(item);
            }
            foreach (var item in dsnguyenlieu)
            {
                dsNguyenLieu.Add(item);
            }
        }
        public Database(Database database)
        {
            tendatabase = "";
            tentable = "";
            chuoiketnoi = "";
            dsDoUong = new List<DoUong>();
            dsNguyenLieu = new List<NguyenLieu>();
            dsNhanVien = new List<NhanVien>();
            kieudatabase = 0; //SQLSever
        }
        public string moKetNoi(params object[] thamso)
        {
            return "Mo Ket Noi";
        }
        public string tenDatabase(params object[] thamso)
        {
            string B1 = moKetNoi();
            return "Ten Database";
        }
        public string tenTable(params object[] thamso)
        {
            string B2 = tenDatabase();
            return "Ten Table";
        }
        public string dongKetNoi(params object[] thamso)
        {
            string B1 = moKetNoi();
            return "Dong Ket Noi";
        }

        public delegate object truyvanHandel(params object[] thamso);
        public event truyvanHandel truyvanEvent;


        public object truyVan(params object[] thamso)
        {
            string kqB1 = this.moKetNoi(thamso);
            string kqB2 = this.tenDatabase(kqB1);
            this.tenTable(kqB2);
            object kqB4 = truyvanEvent?.Invoke(thamso);
            this.dongKetNoi(kqB1);
            return kqB4;
        }
    }

}
