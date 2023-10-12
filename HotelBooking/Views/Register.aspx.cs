using HotelBooking.Views.Admin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBooking.Views
{
    public partial class Register : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string UName = UNameTb.Value;
                string UPhone = PhoneTb.Value;
                string UGen = GenCb.SelectedValue.ToString();
                string UAdd = AddressTb.Value;
                string UPass = PasswordTb.Value;
                string Query = "insert into UserTbl values ('{0}','{1}','{2}','{3}','{4}')";
                Query = string.Format(Query, UName, UPhone, UGen, UAdd, UPass);
                Con.setData(Query);
                UNameTb.Value = "";
                PhoneTb.Value = "";
                GenCb.SelectedIndex = -1;
                AddressTb.Value = "";
                PasswordTb.Value = "";
                Response.Redirect("Login.aspx");

            }
            catch (Exception Ex)
            {
                    
                ErrMsg.InnerText = Ex.Message;

            }
        }
    }
}