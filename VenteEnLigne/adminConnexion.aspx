<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="adminConnexion.aspx.vb" Inherits="VenteEnLigne.adminConnexion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="container">
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            
            <br />
            <br />
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-success">
                    <div class="panel-heading">Admin</div>
                    <div class="panel-body">
                        <div class="form-group">
                            <label>Compte :</label>
                            <asp:TextBox ID="TextBox1" runat="server" Width="461px" CssClass="form-control"></asp:TextBox>
                            
                        </div>
                        <div class="form-group">
                            <label>Mot de passe :</label>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="461px" CssClass="form-control"></asp:TextBox>
                             
                             
                        </div>
                        <asp:Button ID="Button1" runat="server" Text="connexion" Width="117px" CssClass="btn btn-success" />
                        
                    </div>
                </div>
            </div>

        </div>

    </div>
    </form>

    
    <script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/bootstrap.min.js"></script>
</body>
</html>
