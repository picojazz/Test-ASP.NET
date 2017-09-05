<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="gestionClient.aspx.vb" Inherits="VenteEnLigne.gestionClient" %>

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
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

           <h1 class="text-center">Gestion des Clients</h1>
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-success">
                    <div class="panel-heading">Liste des clients</div>
                    <div class="panel-body">
                       <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </div>
                </div>
            </div>

           

        </div>



    </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {

            $(".supp").on("click", function (e) {
               
               return confirm("etes vous sur de vouloir supprimer ce client")
            })

        })
    </script>
  
</body>
</html>
