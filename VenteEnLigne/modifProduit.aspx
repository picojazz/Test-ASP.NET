<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="modifProduit.aspx.vb" Inherits="VenteEnLigne.modifProduit" %>

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
                    <div class="panel-heading">Modification du produit</div>
                    <div class="panel-body">
                         <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="">Code du Produit :</label>
                                <asp:Label ID="codeP" runat="server" Text="Label"></asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="">Designation :</label>
                                <asp:Label ID="des" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="form-group">
                                    <label for="">Prix Unitaire :</label>
                                <asp:Label ID="pu" runat="server" Text="Label"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <label for="">Quantite en stock:</label>
                                <asp:Label ID="qte" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                      <asp:Button ID="Button1" runat="server" Text="Modifier" CssClass="btn btn-success  btn-block"  />
                    </div>
                </div>
            </div>

           

        </div>
    </div>
    </form>
</body>
</html>
