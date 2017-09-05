Public Class adminConnexion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim compte As String = Request.Form("TextBox1")
        Dim passe As String = Request.Form("TextBox2")
        If compte = "admin" And passe = "admin" Then
            Session("isOpen") = "1"
            Session("admin") = "99"
            Response.Redirect("gestionClient.aspx")
        Else
            Label1.Text = "<div class='alert alert-danger'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>Erreur de connexion</strong><br/> compte ou mot de passe incorrect !!!</div>"

        End If
       

    End Sub
End Class