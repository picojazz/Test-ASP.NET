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
            <div class="col-md-8 col-md-offset-2">
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
</body>
</html>
