﻿using HotelBooking.Views.Admin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBooking.Views.User
{
    public partial class Booking : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowRooms();
            ShowBooking();
        }
        private void ShowRooms()
        {
            string St = "Availabel";
            string Query = "select RId as Id,RName as Name,RCategory as  categories, RCost as Cost,Status as Status from RoomTbl where status='"+St+"'";
            RoomsGV.DataSource = Con.GetData(Query);
            RoomsGV.DataBind();
        }
        private void ShowBooking()
        {
            string Query = "select * from BookingTbl";
            BookingGV.DataSource = Con.GetData(Query);
            BookingGV.DataBind();
        }
        int Key = 0;
        int Days = 1;
        protected void RoomsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(RoomsGV.SelectedRow.Cells[1].Text);
            RoomTb.Value = RoomsGV.SelectedRow.Cells[2].Text;
            int Cost = Days * Convert.ToInt32(RoomsGV.SelectedRow.Cells[4].Text);
            AmountTb.Value = Cost.ToString();
        }
        private void UpdateRoom()
        {
            try
            {
                string St = "Booked";   
                string Query = "update RoomTbl set Status='{0}' where RId={1}";
                Query = string.Format(Query,St, RoomsGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowRooms();
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int TCost;
        private void GetCost()
        {
            // Date Time = DDMMYY
            DateTime DIn = DateTime.TryParseExact(DateInTb.Value.ToString(),"dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime DOut = DateTime.ParseExact(DateOutTb.Value.ToString(),"dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan value=DOut.Subtract(DIn);
            int Days=Convert.ToInt32(value.TotalDays);
            TCost =Days * Convert.ToInt32(RoomsGV.SelectedRow.Cells[4].Text);
        }
        protected void BookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RId = RoomsGV.SelectedRow.Cells[1].Text;
                string BDate = System.DateTime.Today.Date.ToString();
                string InDate = DateInTb.Value.ToString();
                string OutDate = DateOutTb.Value.ToString();
                string Agent = Session["UId"]  as string;
                GetCost();
               
                string Query = "insert into BookingTbl values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, BDate, RId, Agent, InDate, OutDate, TCost);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Booked!!!";
                RoomTb.Value = "";
                UpdateRoom();
                ShowBooking();
                AmountTb.Value = "";

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}