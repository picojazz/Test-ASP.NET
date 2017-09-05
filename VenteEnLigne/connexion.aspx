<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="connexion.aspx.vb" Inherits="VenteEnLigne.connexion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-primary">
                    <div class="panel-heading">CONNEXION</div>
                    <div class="panel-body">
                        <div class="form-group">
                            <label>Compte :</label>
                            <asp:TextBox ID="compte" runat="server" Width="461px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Mot de passe :</label>
                             <asp:TextBox ID="passe" runat="server" TextMode="Password" Width="461px" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Button ID="Connexion" runat="server" Text="connexion" Width="117px" CssClass="btn btn-primary"/>
                        <p>Pas de compte ? <a href="inscription.aspx">S'inscrire</a></p>
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
