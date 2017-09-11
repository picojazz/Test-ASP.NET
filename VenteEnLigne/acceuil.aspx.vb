Public Class acceuil
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Application("logout") = 1 Then
            Label1.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>deconnexion reussie </strong><br/> Vous etes bien deconnecter !!!</div>"
            Application("logout") = 0
        Else
            Label1.Text = ""
        End If
    End Sub

End Class