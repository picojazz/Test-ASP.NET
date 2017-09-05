<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="listeCommande.aspx.vb" Inherits="VenteEnLigne.listeCommande" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <!-- #include file ="header.html" -->
    <form id="form1" runat="server">
    <div class="container">
        <div class="col-md-12 ">
            
            <div class="panel panel-primary">
                  <div class="panel-heading">
                        <h3 class="panel-title">Mes commandes</h3>
                  </div>
                  <div class="panel-body">
                        
                        <table class="table table-hover table-striped">
                            <thead>
                                <tr>
                                    <th>Numero Commande</th>
                                    <th>Date de la commande</th>
                                    <th>Designation</th>
                                    <th>Prix unitaire</th>
                                    <th>Quantite</th>
                                    <th>Montant de la commande</th>
                                    <th>Description</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </tbody>
                        </table>
                      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        
                  </div>
            </div>
            
        </div>
    </div>
    </form>
</body>
</html>
