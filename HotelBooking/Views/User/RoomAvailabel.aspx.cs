using HotelBooking.Views.Admin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBooking.Views.User
{
    public partial class RoomAvailabel : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowRooms();
        }
        private void ShowRooms()
        {
            string St = "Availabel";
            string Query = "select RId as Id,RName as Name,RCategory as  categories, RCost as Cost,Status as Status from RoomTbl where status='" + St + "'";
            RoomsGV.DataSource = Con.GetData(Query);
            RoomsGV.DataBind();
        }



    }
}