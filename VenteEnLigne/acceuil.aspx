<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="acceuil.aspx.vb" Inherits="VenteEnLigne.acceuil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="css/mycss.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br /><br />
  <div class="jumbotron text-center">
    <h1 class="text-primary">Picojazz Market</h1> 
    <p>Picojazz Market est un site e-commerce destiné aux clients qui souhaite passer leur commande sans se deplacer</p> 
    <a href="inscription.aspx" class="  btn btn-lg btn-primary">Inscrivez-vous des maintenant</a><br />
      <p class="small">Vous avez deja un compte ? <a href="connexion.aspx" class="text-primary" >Connectez-vous</a></p>
   
  </div>

            <p class="text-right">Copyright  <span style="color:blue;">PICOJAZZ 2017</span></p>
  
</div>
    
    </div>
    </form>

    <script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/bootstrap.min.js"></script>
</body>
</html>
