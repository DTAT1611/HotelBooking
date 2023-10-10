<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="HotelBooking.Views.Admin.Rooms" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4"><h1 class="text-success text-center">Manage Rooms</h1></div>
            <div class="col-4"></div> 
        </div>
        <div class="row">
            <div class="col-md-3">
             <form>
          <div class="mb-3">
            <label for="RNameTb" class="form-label">Room Name</label>
            <input type="text" class="form-control" id="RNameTb" runat="server" required="required"/>
          </div>
          <div class="mb-3">
            <label for="CatCb" class="form-label">Categories</label>
              <asp:DropDownList ID="CatCb" runat="server" class="form-control"></asp:DropDownList>
          </div>
          <div class="mb-3">
            <label for="LocationTb" class="form-label">Location</label>
            <input type="text" class="form-control" id="LocationTb"  runat="server" required="required"/>
          </div>
          <div class="mb-3">
            <label for="CostTb" class="form-label">Room Cost</label>
            <input type="text" class="form-control" id="CostTb"  runat="server" required="required"/>
          </div>
                 <div class="mb-3">
            <label for="ReamrksTb" class="form-label">Remarks</label>
            <input type="text" class="form-control" id="RemarksTb"  runat="server" required="required"/>
          </div>
                  <div class="mb-3">
            <label for="StatusCb" class="form-label">Status</label>
              <asp:DropDownList ID="StatusCb" runat="server" class="form-control">
                  <asp:ListItem>Availabel</asp:ListItem>
                  <asp:ListItem>Booked</asp:ListItem>
              </asp:DropDownList>
          </div>
                     <div class="row">
             <div class="col d-grid">
                  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning btn-block" OnClick="EditBtn_Click"  />
             </div>
                      <div class="col d-grid">
                           <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger btn-block" OnClick="DeleteBtn_Click" />
                      </div>
                       <br />
                    </div>
                    <div class="d-grid">
                        <label id="ErrMsg" runat="server" class="text-danger"></label>
                        <asp:Button ID="SaveBtn" runat="server" Text="Save" class="btn btn-success btn-block" OnClick="SaveBtn_Click"/>
                    </div>                 
        
                    <br />
        </form>
            </div>
            <div class="col-md-9">
                <asp:GridView ID="RoomsGV" runat="server" class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="RoomsGV_SelectedIndexChanged1">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
