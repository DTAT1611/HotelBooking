<%@ Page Title="" Language="C#" MasterPageFile="~/Views/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="RoomAvailabel.aspx.cs" Inherits="HotelBooking.Views.User.RoomAvailabel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col">
                <div class="row">
                                            <label id="ErrMsg" runat="server" class="text-danger"></label>
                 <a class="nav-link text-success" href="../User/Booking.aspx">Booking click this</a>
                </div>
                <h3 class="text-primary">Rooms</h3>
                  <asp:GridView ID="RoomsGV" runat="server" class="table" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" >
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </div>


        </div>
    </div>
</asp:Content>
