<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="doCommande.aspx.vb" Inherits="VenteEnLigne.doCommande" %>

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
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <div class="row">
            <h3 class="text-center">version 1</h3>
        <div class="col-md-6 col-md-offset-3">
            
            <div class="panel panel-primary">
                  <div class="panel-heading">
                        <h3 class="panel-title">nouvelle commande</h3>
                  </div>
                  <div class="panel-body">
                        <div class="form-group">
                            <label for="">Selectionner un produit : </label>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label for="">Quantite :
                            </label>
                           <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </div>
                        
                        <asp:Button ID="Button1" runat="server" Text="Commander" CssClass="btn btn-large btn-block btn-success" />
                        
                  </div>
            </div>
            
        </div>
    </div>
    <div class="row">
        <h3 class="text-center">version 2</h3>
        
        <div class="panel panel-primary">
              <div class="panel-heading">
                    <h3 class="panel-title">Liste des produits</h3>
              </div>
              <div class="panel-body">
                    
                  <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    
                  
                    
              </div>
        </div>
        

    </div>
    </div>

    
   
    <div class="modal fade" id="modal-id">
        <div class="modal-dialog">
            <div class="modal-content">
                
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title">Details de la commande</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="">Code du Produit :</label>
                                <label class="codeProd"></label>
                            </div>
                            <div class="form-group">
                                <label for="">Designation :</label>
                                <label class="des"></label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="form-group">
                                    <label for="">Prix Unitaire :</label>
                                    <label class="prixUnit"></label>
                                </div>
                                <div class="form-group">
                                    <label for="">Quantite en stock:</label>
                                    <label class="qte"></label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                    <div class="col-md-8 col-md-offset-2 modContent">
                        <div class="form-group">
                            <label for="">Quantite :</label>
                            <input type="number" name="qte1" class="form-control qtes">
                            <input type="hidden" name="codePro" class="prod">
                        </div>
                        <div class="form-group">
                            <label for="">description :</label>
                            <textarea class="form-control desc" cols="40" rows="5" name="desc"></textarea>
                        </div>
                    </div>
                    </div>
                    
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button2" runat="server" Text="commander" CssClass="btn btn-success" />
                    
                </div>
            </div>
        </div>
    </div>
    
        
    </form>
<script type="text/javascript">
    $(document).ready(function(){
        $(".voir").click(function(){
             $(".qtes").val("")
             $(".desc").val("")
            $(".prod").val($(this).parents("tr").find('td:eq(0)').text())
            $(".codeProd").html($(this).parents("tr").find('td:eq(0)').text())
            $(".des").html($(this).parents("tr").find('td:eq(1)').text())
            $(".prixUnit").html($(this).parents("tr").find('td:eq(2)').text())
            $(".qte").html($(this).parents("tr").find('td:eq(3)').text())
        })
       

        
        


    })
</script>
</body>
</html>
