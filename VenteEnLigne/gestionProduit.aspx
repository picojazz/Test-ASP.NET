<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="gestionProduit.aspx.vb" Inherits="VenteEnLigne.gestionProduit" %>

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
           <h1 class="text-center">Gestion des produits</h1>
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-success">
                    <div class="panel-heading">Liste des Produits</div>
                    <div class="panel-body">
                       <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </div>
                </div>
            </div>

           

        </div>
    
    </div>
    </form>
</body>
</html>
