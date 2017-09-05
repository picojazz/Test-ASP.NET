Public Class connexion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Application("str") = 1 Then
            Label2.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>Inscription reussie</strong><br/> veuillez vous connecter maintenant !!!</div>"
            Application("str") = 0
        Else
            Label2.Text = ""
        End If
        If Application("logout") = 1 Then
            Label2.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>deconnexion reussie </strong><br/> Vous etes bien deconecter !!!</div>"
            Application("logout") = 0
        End If
    End Sub

    Protected Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles Connexion.Click

        Dim compte As String = Request.Form("Compte")
        Dim passe As String = Request.Form("Passe")
        dr = login(compte, passe)
        If dr.HasRows Then
            Session("isOpen") = "1"
            Dim dt As New DataTable
            dt.Load(dr)
            Session("client") = dt
            Response.Redirect("infoClient.aspx")


        Else
            Label1.Text = "<div class='alert alert-danger'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button><strong>Erreur de connexion</strong><br/> compte ou mot de passe incorrect !!!</div>"

        End If




        dr.Close()


    End Sub
End Class