using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBooking.Views.Admin
{
    public partial class Rooms : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowRooms();
            if (!IsPostBack)
            {
                GetCategories();
            }
            
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowRooms()
        {
            string Query = "Select * from RoomTbl";
            RoomsGV.DataSource = Con.GetData(Query);
            RoomsGV.DataBind();
        }
        private void GetCategories()
        {
            string Query = "Select * from CategoryTbl";
            CatCb.DataTextField=Con.GetData(Query).Columns["CatName"].ToString();
            CatCb.DataValueField = Con.GetData(Query).Columns["CatId"].ToString();                                                                           
            CatCb.DataSource = Con.GetData(Query);
            CatCb.DataBind();
        }
        protected void RoomsGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = RNameTb.Value;
                string RCat = CatCb.SelectedValue.ToString();
                string RLoc=LocationTb.Value;
                string Cost = CostTb.Value;
                string Rem=RemarksTb.Value;
                string Status = "Availabel";
                string Query = "insert into RoomTbl values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, RName, RCat,RLoc,Cost,Rem,Status);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Added!!!";
                RNameTb.Value="";
                CatCb.SelectedIndex= -1;
                LocationTb.Value = "";
                CostTb.Value = "";
                RemarksTb.Value = "";
                
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void RoomsGV_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(RoomsGV.SelectedRow.Cells[1].Text);
            RNameTb.Value = RoomsGV.SelectedRow.Cells[2].Text;
            CatCb.SelectedValue = RoomsGV.SelectedRow.Cells[3].Text;
            LocationTb.Value = RoomsGV.SelectedRow.Cells[4].Text;
            CostTb.Value = RoomsGV.SelectedRow.Cells[5].Text;
            RemarksTb.Value = RoomsGV.SelectedRow.Cells[6].Text;
            StatusCb.SelectedValue = RoomsGV.SelectedRow.Cells[7].Text;
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = RNameTb.Value;
                string RCat = CatCb.SelectedValue.ToString();
                string RLoc = LocationTb.Value;
                string Cost = CostTb.Value;
                string Rem = RemarksTb.Value;
                string Status = StatusCb.SelectedValue.ToString();
                string Query = "update RoomTbl set RName= '{0}',RCategory='{1}',RLocation='{2}',RCost='{3}',RRemarks='{4}',Status='{5}' where RId='{6}'";
                Query = string.Format(Query, RName, RCat, RLoc, Cost, Rem, Status, RoomsGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room updated!!!";
                RNameTb.Value = "";
                CatCb.SelectedIndex = -1;
                LocationTb.Value = "";
                CostTb.Value = "";
                RemarksTb.Value = "";

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string Query = "delete from RoomTbl where RId={0}";
                Query = string.Format(Query, RoomsGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Deleted!!!";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}