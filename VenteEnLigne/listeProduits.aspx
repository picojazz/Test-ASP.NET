<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="listeProduits.aspx.vb" Inherits="VenteEnLigne.listeProduits" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        
    <!-- #include file ="header.html" -->
    
       <div class="container">
           <h1 class="text-center">Liste des produits</h1>
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-primary">
                    <div class="panel-heading"><asp:Label ID="Label2" runat="server" Text="Label" ForeColor="White"></asp:Label></div>
                    <div class="panel-body">
                       <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </div>
                </div>
            </div>

           <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

        </div>


        <div>
          

            

        </div>
        
    </form>

    <div class="modal fade" id="modal-id">
        <div class="modal-dialog">
            <div class="modal-content">
                
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title">Details du produit</h4>
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
                    <div class="col-md-8 col-md-offset-2 ">
                        <div class="form-group">
                                    <label for="">Photo:</label>
                                    <label class="photo"><img src="" width="300px" height="300px" /></label>
                                </div>
                    </div>
                    </div>
                    
                </div>
                
            </div>
        </div>
    </div>


    <script type="text/javascript">
        $(document).ready(function () {


            $(".voir").click(function () {
                $(".qtes").val("")
                $(".desc").val("")
                $(".prod").val($(this).parents("tr").find('td:eq(0)').text())
                $(".codeProd").html($(this).parents("tr").find('td:eq(0)').text())
                $(".des").html($(this).parents("tr").find('td:eq(2)').text())
                $(".prixUnit").html($(this).parents("tr").find('td:eq(3)').text() + " F")
                $(".qte").html($(this).parents("tr").find('td:eq(4)').text())
                $(".photo img").attr("src", $(this).parents("tr").find('td:eq(1)').find('img').attr("src"))
            })

            

        })
    </script>

</body>
</html>
