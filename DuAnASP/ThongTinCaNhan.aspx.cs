using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnASP
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //khoi tao cho ddlTrinhDo
            ddlTrinhDo.Items.Add(new ListItem("Trung cấp"));
            ddlTrinhDo.Items.Add(new ListItem("Cao đẳng"));
            //...

            //khoi tao cho lstNgheNghiep
            lstNgheNghiep.Items.Add(new ListItem("Công nhân"));
            lstNgheNghiep.Items.Add(new ListItem("Lập trình viên"));
            lstNgheNghiep.Items.Add(new ListItem("Kỹ sư"));
            //...

            //khoi tao cho chkListSoThich
            chkListSoThich.Items.Add(new ListItem("batman"));
            chkListSoThich.Items.Add(new ListItem("Xem phim"));
            chkListSoThich.Items.Add(new ListItem("$$$$"));
            chkListSoThich.Items.Add(new ListItem("gril"));

            
        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            
                string kq = "";
                kq += "<h2> Thông tin đăng ký của bạn</h2>";
                kq += "<ul>";

                kq += $"<li>Họ tên {txtHoTen}</li>";
                kq += string.Format("<li> Ngày Sinh: {0} </li>", txtNgaySinh.Text);
                if (rdNam.Checked)
                {
                    kq += $"<li> Gới Tinh {rdNam.Text} </li>";
                }
                else
                {
                    kq += $"<li> Gới Tinh {rdNu.Text} </li>";
                }
                kq += $"<li>Trình Dộ {ddlTrinhDo.SelectedItem.Text}</li>";
                kq += $"<li> NGhề Nghiệp {lstNgheNghiep.SelectedItem.Text}<li/>";

                if (FHinh.HasFile)
                {
                    string path = Server.MapPath("~/Uploads");
                    FHinh.SaveAs(path + "/" + FHinh.FileName);
                    kq += $"<li> Ảnh: <img src='Uploads/{ FHinh.FileName} '><?li>";
                }
                kq +="<ul >";
                lbKetQua.Text = kq;
            
        }
    }
}