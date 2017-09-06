<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="gestionCommande.aspx.vb" Inherits="VenteEnLigne.gestionCommande" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
     <!-- #include file ="headerAdmin.html" -->
    <form id="form1" runat="server">
    <div>
                
        <div class="container">
             
           
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-success">
                    <div class="panel-heading">Recherche de commande entre deux dates</div>
                    <div class="panel-body">
                       
                        
                            <div class="form-inline text-center">
                                <label for="">de :</label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" TextMode="Date" Height="35px"></asp:TextBox>
                                <label for="">à :</label>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Date" Height="35px"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" Text="rechercher" CssClass="btn btn-success" />

                                 </div>
                        
                       
                    
                    </div>
                </div>
                <br />
            <br />
            </div>
            

        <div class="container">
            
           
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-success">
                    <div class="panel-heading">Liste des Commandes</div>
                    <div class="panel-body">
                       

                    
                    </div>
                </div>
            </div>

           

        </div>


    </div>
    </form>
</body>
</html>
