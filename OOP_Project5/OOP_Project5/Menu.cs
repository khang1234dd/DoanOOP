using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project5
{
    public class Menu
    {
        public string tenmenu { set; get; }
        public string loaimenu { set; get; }
        List<DoUong> dsDoUongDaBan { set; get; }
        public List<DoUong> menu { set; get; }
        Database dtb;
        public Menu()
        {
            tenmenu = "menu";
            loaimenu = "menu do uong";
            menu = new List<DoUong>();
            dsDoUongDaBan = new List<DoUong>();
            dtb = new Database();
        }
        public Menu(Database dtb)
        {
            tenmenu = "menu";
            loaimenu = "menu do uong";
            menu = new List<DoUong>();
            dsDoUongDaBan = new List<DoUong>();
            this.dtb = new Database();
            this.dtb = dtb;
        }
        public string xoaDoUong(DoUong douong)
        {

             menu.Remove(douong);
            return "Xoa do uong: " + douong.tendouong + "ra khoi menu";
        }
        public string banDoUong(DoUong douong,int soluongbanra)
        {
            foreach(DoUong item in menu)
            {
                if(item == douong)
                {
                    if (item.soluong == 0)
                    {
                        menu.Remove(item);
                        item.soluongdaban = item.soluong + 1;
                    }
                    
                    if(item.soluong < soluongbanra)
                    {
                        return item.tendouong + ": so luong khong du";
                    }
                    else if(item.soluong > 0)
                    {
                        item.soluong = item.soluong - soluongbanra;
                        item.soluongdaban = item.soluongdaban + soluongbanra;
                    }
                    dsDoUongDaBan.Add(item);
                }

            }
            return "Ban do uong: " + douong.tendouong +"\n" +"So luong con lai: " + douong.soluong;
        }
        public string themDoUong(DoUong douong)
        {
            menu.Add(douong);
            return "Them do uong : " + douong.tendouong + " vao menu";
        }
        public string themTatCaDoUong()
        {
            foreach (DoUong item in dtb.dsDoUong)
            {
                menu.Add(item);
            }
            return "Da them tat ca do uong vao menu";
        }

    }
}
