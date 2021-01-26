using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Database
            //Tao doi tuong cho Database
            Database dtb = new Database();
            #endregion
            #region NhanVien
            //Tao doi tuong nhan vien
            NhanVien nhanvien1 = new NhanVien();
            NhanVien nhanvien2 = new NhanVien("nv2", "Dang Minh Khang", DateTime.Now, "anh1", "ketoan", "hieukhach",dtb);
            //Add nhanvien vao danh sach nhan vien
            dtb.dsNhanVien.Add(nhanvien1);
            dtb.dsNhanVien.Add(nhanvien2);
            #endregion
            #region Nguyen Lieu
            //Tao doi tuong nguyen lieu
            NguyenLieu nguyenlieu1 = new NguyenLieu("tra",100,dtb);
            NguyenLieu nguyenlieu2 = new NguyenLieu("nl2",200,dtb);
            NguyenLieu nguyenlieu3 = new NguyenLieu("nl3",300,dtb);
            NguyenLieu nguyenlieu4 = new NguyenLieu("nl4",350,dtb);
            NguyenLieu nguyenlieu5 = new NguyenLieu("nl5",240,dtb);
            NguyenLieu nguyenlieu6 = new NguyenLieu("nl6",150,dtb);

            NguyenLieu nguyenlieu7 = new NguyenLieu("nl7", 8, dtb);

            dtb.dsNguyenLieu.Add(nguyenlieu1);
            dtb.dsNguyenLieu.Add(nguyenlieu2);
            dtb.dsNguyenLieu.Add(nguyenlieu3);
            dtb.dsNguyenLieu.Add(nguyenlieu4);
            dtb.dsNguyenLieu.Add(nguyenlieu5);
            dtb.dsNguyenLieu.Add(nguyenlieu6);


            //xai phuong thuc kiem tra nguyen lieu

            // kiem tra nguyen lieu da co trong dtb roi
            string kt1 = nguyenlieu3.kiemtraNguyenLieu();
            Console.WriteLine(kt1);

            // kiem tra nguyen lieu chua co trong dtb
            string kt2 = nguyenlieu7.kiemtraNguyenLieu();
            Console.WriteLine(kt2);

            #endregion
            #region Do Uong
            // Tao doi tuong do uong

            DoUong douong1 = new DoUongPhaChe("TraSuaCaPhe", 30000, 40000, 5, dtb);
            DoUong douong2 = new DoUongPhaChe("TraSuaMattcha", 25000, 35000, 5, dtb);
            DoUong douong3 = new DoUongPhaChe("TraSuaTruyenThong", 30000, 40000, 10, dtb);
            DoUong douong4 = new DoUongPhaChe("TraSuaCaCao", 35000, 45000, 3, dtb);
            DoUong douong5 = new DoUongPhaChe("TraSuaTranChau", 40000, 50000, 2, dtb);
            DoUong douong6 = new DoUongCoGas("Pepsi", 5000, 10000, 20, dtb);
            DoUong douong7 = new DoUongCoGas("Xaxi", 3000, 10000, 20, dtb);
            DoUong douong8 = new DoUongCoGas("CoCaCoLa", 5000, 10000, 20, dtb);
            DoUong douong9 = new DoUongCoGas("Sting", 3000, 10000, 20, dtb);
            DoUong douong10 = new DoUongCoGas("7up", 5000, 10000, 20, dtb);
            DoUong douong11 = new DoUongBoSung("Nutifood", 8000, 14000, 20, dtb);
            DoUong douong12 = new DoUongBoSung("SuaBap", 5000, 12000, 20, dtb);
            DoUong douong13 = new DoUongBoSung("NuocNho", 5000, 10000, 20, dtb);
            DoUong douong14 = new DoUongBoSung("TraBiDao", 2000, 8000, 20, dtb);
            DoUong douong15 = new DoUongBoSung("BoCung", 5000, 15000, 20, dtb);


            dtb.dsDoUong.Add(douong1);
            dtb.dsDoUong.Add(douong2);
            dtb.dsDoUong.Add(douong3);
            dtb.dsDoUong.Add(douong4);
            dtb.dsDoUong.Add(douong5);
            dtb.dsDoUong.Add(douong6);
            dtb.dsDoUong.Add(douong7);
            dtb.dsDoUong.Add(douong8);
            dtb.dsDoUong.Add(douong9);
            dtb.dsDoUong.Add(douong10);
            dtb.dsDoUong.Add(douong11);
            dtb.dsDoUong.Add(douong12);
            dtb.dsDoUong.Add(douong13);
            dtb.dsDoUong.Add(douong14);
            dtb.dsDoUong.Add(douong15);

            //phuong thuc tren do uong (1 ->5 la do uong pha che ; 6 ->10 la do uong co gas ; 11 -> 15 do uong bo sung)
            //do uong pha che
            string thongtin1 = douong1.thongTinDoUong();
            Console.WriteLine(thongtin1);

            //do uong co gas
            string thongtin2 = douong7.thongTinDoUong();
            Console.WriteLine(thongtin2);

            //do uong bo sung

            string thongtin3 = douong14.thongTinDoUong();
            Console.WriteLine(thongtin3);

            //Ket hop 2 do uong su dung operator
            DoUong douongkethop = douong1 + douong7;
            Console.WriteLine(douongkethop.GetType());

            #endregion
            #region Menu
            //Tao doi tuong Menu

            Menu menu = new Menu(dtb);


            //phuong thuc menu
            // them tat ca do uong
            string them = menu.themTatCaDoUong();
            foreach (var item in menu.menu)
            {
                Console.Write(item.tendouong + " ");
            }
            Console.WriteLine(them);

            DoUong douong16 = new DoUongCoGas() { tendouong = "Mirinda" };
            //them 1 do uong
            string them1 = menu.themDoUong(douong16);
            Console.WriteLine(them1);

            //show
            foreach (var item in menu.menu)
            {
                Console.Write(item.tendouong + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //xoa do uong
            string xoa = menu.xoaDoUong(douong16);
            Console.WriteLine(xoa);
            //show lai
            foreach (var item in menu.menu)
            {
                Console.Write(item.tendouong + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // ban do uong
            string ban1 = menu.banDoUong(douong3,4);
            string ban2 = menu.banDoUong(douong14, 7);
            string ban3 = menu.banDoUong(douong3, 4);
            string ban4 = menu.banDoUong(douong3, 4);
            Console.WriteLine(ban1+"\n"+ ban2+"\n" + "\n"+ ban3+ "\n"+ ban4);

            #endregion
            #region quan ly thu chi
            //Tao doi tuong quanlythuchi

            QuanLyThuChi quanlythuchi = new QuanLyThuChi(dtb);
            quanlythuchi.layDuLieuDatabase();

            //phuong thuc thu , chi va tinh tien lo lai.
            int thu = quanlythuchi.tongThu();
            int chi = quanlythuchi.tongChi();
            string kq = quanlythuchi.tinhLoiLo();


            Console.WriteLine("Tong thu: thu: " +thu);
            Console.WriteLine("Tong thu: chi: " + chi);
            Console.WriteLine(kq);
            #endregion


        }
    }
}
