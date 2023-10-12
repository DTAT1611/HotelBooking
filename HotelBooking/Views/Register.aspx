<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HotelBooking.Views.Register"  EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/bootstrap/css/bootstrap.min.css" />
    <style>
        body{
             background: url(../Assets/Image/hotel1.jpg);
            background-size:cover;
        }
        .container-fluid {
            opacity:0.9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <div class="container-fluid">
        <div class="row">
            <div class="row" style="height:120px;"></div>
            <div class="col-md-4"></div>
            <div class="col-md-4 bg-light rounded-3">
                <h1 class="text-success text-center">Hotel</h1>
                <form>
         <div class="mb-3">
            <label for="UNameTb" class="form-label">Users Name</label>
            <input type="text" class="form-control" id="UNameTb" runat="server"/>
          </div>
          <div class="mb-3">
            <label for="PhoneTb" class="form-label">Phone</label>
            <input type="text" class="form-control" id="PhoneTb" runat="server"/>
          </div>
          <div class="mb-3">
            <label for="GenCb" class="form-label">Gender</label>
              <asp:DropDownList ID="GenCb" runat="server" class="form-control">
                  <asp:ListItem>Male</asp:ListItem>
                  <asp:ListItem>Female</asp:ListItem>
              </asp:DropDownList>
          </div>
          <div class="mb-3">
            <label for="AddressTb" class="form-label">Address</label>
            <input type="text" class="form-control" id="AddressTb" runat="server"/>
          </div>
                 <div class="mb-3">
            <label for="PasswordTb" class="form-label">Password</label>
            <input type="text" class="form-control" TextMode="Password" id="PasswordTb" runat="server"/>
          </div>
                    <div class="d-grid">
                        <label id="ErrMsg" class="text-danger" runat="server"></label>
                        <asp:Button ID="RegisterBtn" runat="server" Text="Register" class="btn btn-success btn-block" OnClick="RegisterBtn_Click" />
                    </div>
        
                    <br />
                    
        </form>
            </div>
            <div class="col-md-4"></div>
        </div>
       

    </div>
        </div>
    </form>

</body>
</html>
<script>
    window.onload = function() {
        var passwordInput = document.getElementById("PasswordTb");
        passwordInput.type = "password";
    };
</script>

