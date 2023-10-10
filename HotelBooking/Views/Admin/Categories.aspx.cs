using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBooking.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCategories()
        {
            string Query = "select CatId as Id,CatName as Categories,CatName as Categories,CatRemarks as Remarks from CategoryTbl";
            CategoriesGV.DataSource= Con.GetData(Query);
            CategoriesGV.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CatName = CatNameTb.Value;
                string Rem = RemarkTb.Value;
                string Query = "insert into CategoryTbl values ('{0}','{1}')";
                Query = string.Format(Query, CatName, Rem);
                Con.setData(Query);
                ShowCategories();
                ErrMsg.InnerText = "Category Added!!!";
            }
            catch(Exception Ex)
            {
                ErrMsg.InnerText=Ex.Message;
            }
        }
        int Key = 0;
        protected void CategoriesGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(CategoriesGV.SelectedRow.Cells[1].Text);
            CatNameTb.Value = CategoriesGV.SelectedRow.Cells[2].Text;
            RemarkTb.Value = CategoriesGV.SelectedRow.Cells[4].Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string CatName = CatNameTb.Value;
                string Rem = RemarkTb.Value;
                string Query = "update CategoryTbl set CatName='{0}',CatRemarks='{1}' where CatId={2}";
                Query = string.Format(Query, CatName, Rem, CategoriesGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowCategories();
                ErrMsg.InnerText = "Category Updated!!!";
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
                string CatName = CatNameTb.Value;
                string Rem = RemarkTb.Value;
                string Query = "delete from CategoryTbl where CatId={0}";
                Query = string.Format(Query,CategoriesGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowCategories();
                ErrMsg.InnerText = "Category Deleted!!!";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}