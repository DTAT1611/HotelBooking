using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBooking.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            Session["UserName"] = "";
            Session["UId"] = "";
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Admin/Rooms.aspx");
            if(AdminCb.Checked)
            {
                if(UserTb.Value== "Admin"&& PasswordTb.Value=="Password")
                {
                    Session["UserName"] = "Admin";
                    Response.Redirect("Admin/Rooms.aspx");
                }
                else
                {
                    ErrMsg.InnerText = "Invalid Admin!!!";
                }
            }
            else
            {
                string Query = "select UId,UName,UPass from UserTbl where UName='{0}' and UPass='{1}'";
                Query = string.Format(Query, UserTb.Value,PasswordTb.Value);
                DataTable dt=Con.GetData(Query);
                if(dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid User!!!";

                }
                else
                {
                    Session["UserName"] = dt.Rows[0][1].ToString();
                    Session["UId"] = dt.Rows[0][0].ToString();
                    Response.Redirect("User/Booking.aspx");
                }
            }
        }
    }
}