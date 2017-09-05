<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="infoClient.aspx.vb" Inherits="VenteEnLigne.infoClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
   
   
</head>
<body>
    <!-- #include file ="header.html" -->
   
    <form id="form2" runat="server">
        
        <div class="container">
            
            <div class="row">
                <a href="modifClient.aspx" class="btn btn-success text-right">Modifier mes informations</a>
                <div class="col-md-8 col-md-offset-2">
                    
                    <div class="panel panel-primary">
                          <div class="panel-heading">
                                <h3 class="panel-title">details</h3>
                          </div>
                          <div class="panel-body">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label for="">matricule :</label>
                                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                        
                                    </div>
                                     <div class="form-group">
                                        <label for="">Nom :</label>
                                         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                        
                                    </div>
                                     <div class="form-group">
                                        <label for="">adresse :</label>
                                         <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                       
                                    </div>
                                     <div class="form-group">
                                        <label for="">ville :</label>
                                         <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                       
                                    </div>
                                </div>
                                <div class="col-md-6">
                                     <div class="form-group">
                                        <label for="">telephone :</label>
                                         <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                       
                                    </div>
                                     <div class="form-group">
                                        <label for="">email :</label>
                                         <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                                       
                                    </div>
                                     <div class="form-group">
                                        <label for="">compte :</label>
                                         <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                                       
                                    </div>
                                </div>
                          </div>
                    </div>
                    
                </div>
            </div>
        </div>
        
    </form>
    
</body>
</html>
