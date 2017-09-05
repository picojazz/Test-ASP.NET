<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="inscription.aspx.vb" Inherits="VenteEnLigne.inscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    
   
</head>
<body>
    <form id="form1" runat="server">

<!-- debut -->

    <div class="container">
        <br>
        <br>
        <%--<asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" CssClass="alert alert-danger"/>--%>
        <div class="col-md-6 col-md-offset-3">
            
            <div class="panel panel-primary">
                  <div class="panel-heading">
                        <h3 class="panel-title">INSCRIPTION</h3>
                  </div>
                  <div class="panel-body">
                        <div class="form-group">
                            <Label>Nom :</Label>
                             <asp:TextBox ID="txtNom" runat="server" Width="478px" CssClass="form-control "></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNom" ErrorMessage="veuillez renseigner le nom" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <Label>Adresse :</Label>
                            <asp:TextBox ID="txtAdresse" runat="server" Width="478px" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdresse" ErrorMessage="veuillez renseigner l'adresse" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    <div class="row">
                        <div class="col-md-4">
                        <div class="form-group">
                            <Label>Ville :</Label>
                            <select name="ville" class="form-control">
                                <option value="Dakar">Dakar</option>
                                <option value="Thies">Thies</option>
                                <option value="Kaolack">Kaolack</option>
                                <option value="Tambacounda">Tambacounda</option>
                            </select>
                        </div>
                        </div>
                        <div class="col-md-8">
                        <div class="form-group">
                            <Label>Telephone :</Label>
                            <asp:TextBox ID="txtTel" runat="server" Width="299px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTel" ErrorMessage="veuillez renseigner le telephone" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        </div>
                    </div>
                        <div class="form-group">
                            <Label>Email :</Label>
                             <asp:TextBox ID="TxtEmail" runat="server" Width="478px" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtEmail" ErrorMessage="veuillez renseigner l'email" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <Label>Compte :</Label>
                             <asp:TextBox ID="txtCompte" runat="server" Width="478px" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCompte" ErrorMessage="veuillez renseigner le compte" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <Label>Mot de Passe :</Label>
                            <asp:TextBox ID="txtPasse" runat="server" TextMode="Password" Width="478px" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPasse" ErrorMessage="veuillez renseigner le mot de passe" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                         <asp:Button ID="btnValider" runat="server" Text="S'inscrire" Width="133px" CssClass="btn btn-lg btn-success" />
                      <p>Vous avez deja un compte ? <a href="connexion.aspx">Connectez-vous</a></p>
                  </div>
            </div>
            
        </div>
    </div>

    </form>
</body>
</html>
