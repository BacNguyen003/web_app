using libtinhtoan;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double a;

            if (double.TryParse(txtRadius.Text, out a))
            {
                if (a > 0)
                {
                    try
                    {
                        double chuvilapphuong = tinhtoan.chuvi(a);
                        double dientichlapphuong = tinhtoan.dientich(a);
                        double thetichlapphuong = tinhtoan.thetich(a);

                        lblResult.Text = $"Chu vi hình lập phương là: {chuvilapphuong:F2}<br/>Diện tích hình lập phương: {dientichlapphuong:F2}<br/>Thể tích hình lập phương: {thetichlapphuong:F2}";
                    }
                    catch (ArgumentException ex)
                    {
                        lblResult.Text = "Lỗi: " + ex.Message;
                    }
                }
                else
                {
                    lblResult.Text = "Bán kính phải lớn hơn 0.";
                }
            }
            else
            {
                lblResult.Text = "Giá trị nhập vào không hợp lệ. Vui lòng nhập một số thực.";
            }
        }
    }
}