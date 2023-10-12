<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HotelBooking.Views.Login" EnableEventValidation="false" %>

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
            <label for="EmailTb" class="form-label">Email address</label>
            <input type="text" class="form-control" id="UserTb" runat="server" />
          </div>
          <div class="mb-3">
            <label for="PasswordTb" class="form-label">Password</label>
            <input type="password" class="form-control" id="PasswordTb" runat="server" />
          </div>
          <div class="mb-3 ">
              <label id="ErrMsg" class="text-danger" runat="server"></label>
            <input type="radio"  id="AdminCb" runat="server" name="Role" checked/><label class="text-success">Admin</label>
              <input type="radio"  id="UserCb"  runat="server" name="Role"/><label class="text-success">User</label>
          </div>
                    <div class="d-grid">
                        <asp:Button ID="LoginBtn" runat="server" Text="Login" class="btn btn-success btn-block" OnClick="LoginBtn_Click" />
                    </div>
                    <br />
                       <a class="nav-link text-success" href="Register.aspx">Register</a>
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

