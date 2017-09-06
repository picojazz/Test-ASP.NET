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
             
           
            <div class="col-md-8 col-md-offset-2 text-center">
                <div class="panel panel-success">
                    <div class="panel-heading">Recherche de commande entre deux dates</div>
                    <div class="panel-body ">
                       
                        
                            <div class="form-inline text-center">
                                <label for="">de :</label>
                                <asp:TextBox ID="de" runat="server" CssClass="form-control" TextMode="Date" Height="35px"></asp:TextBox>
                                <label for="">à :</label>
                                    <asp:TextBox ID="a" runat="server" CssClass="form-control" TextMode="Date" Height="35px"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" Text="rechercher" CssClass="rech btn btn-success" />

                                 </div>
                        
                       
                    
                    </div>
                </div>
                <a href="gestionCommande.aspx" class="btn btn-success " >tous les commandes</a>
                <br />
            <br />
            </div>
            </div>

        <div class="container">
            
           
            <div class="col-md-12 ">
                <div class="panel panel-success">
                    <div class="panel-heading">Liste des Commandes</div>
                    <div class="panel-body">
                       
                           <table class="table table-hover table-striped">
                            <thead>
                                <tr>
                                    <th>Numero Commande</th>
                                    <th>Date de la commande</th>
                                    <th>matricule</th>
                                    <th>nom</th>
                                    <th>codeProd</th>
                                    <th>Designation</th>
                                    <th>Prix unitaire</th>
                                    <th>Quantite</th>
                                    <th>Montant de la commande</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </tbody>
                        </table>
                    
                    </div>
                </div>
            </div>

           

        </div>

            
    </div>
    </form>


</body>
</html>
