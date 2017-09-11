<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="modifClient1.aspx.vb" Inherits="VenteEnLigne.modifClient1" %>

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
    <div class="container">
		<div class="row">
			<div class="col-md-8 col-md-offset-2">
				<div class="panel panel-success">
					<div class="panel-heading">Modification des informations</div>
					<div class="panel-body">
						<div class="row">
							<div class="col-md-6">
								<div class="form-group">
									<label for="">Nom :</label>
									<asp:Label ID="txtNom" runat="server" Text="" ></asp:Label>
								</div>
								<div class="form-group">
									<label for="">Adresse :</label>
                                    <asp:Label ID="txtAdresse" runat="server" Text="" ></asp:Label>
								</div>
								<div class="form-group">
									<label for="">Ville :</label>
                                    <asp:DropDownList ID="lst" runat="server" CssClass="form-control" Width="105px">
                                        <asp:ListItem>dakar</asp:ListItem>
                                        <asp:ListItem>thies</asp:ListItem>
                                        <asp:ListItem>kaolack</asp:ListItem>
                                        <asp:ListItem>tambacounda</asp:ListItem>
                                    </asp:DropDownList>
								</div>
                                <div class="form-group">
									<label for="">Mot de passe :</label>
									<asp:Label ID="mdp" runat="server" Text="" ></asp:Label>
								</div>
							</div>
							<div class="col-md-6">
								<div class="form-group">
									<label for="">Telephone :</label>
									<asp:Label ID="txtTel" runat="server" Text="" ></asp:Label>
								</div>
								<div class="form-group">
									<label for="">Email :</label>
									<asp:Label ID="txtEmail" runat="server" Text="" ></asp:Label>
								</div>
								<div class="form-group">
									<label for="">Compte :</label>
									<asp:Label ID="txtCompte" runat="server" Text="" ></asp:Label>
								</div>
                                
								
							</div>
						</div>
                        <asp:Button ID="Button1" runat="server" Text="Modifier" CssClass="btn btn-block btn-success"  />
					</div>
				</div>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
