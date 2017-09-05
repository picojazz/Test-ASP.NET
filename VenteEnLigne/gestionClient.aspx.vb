Public Class gestionClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()

        If Application("modif") = 1 Then
            Label2.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>client modifié</div>"
            Application("modif") = 0
        ElseIf Application("supp") = 1 Then
            Label2.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>client supprimé</div>"
            Application("supp") = 0
        Else
            Label2.Text = ""
        End If

        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else
            Label1.Text = "<table class=' table table-stripped table-hover'>"
            Label1.Text &= "<tr><th>Matricule</th><th>nom</th><th>adresse</th><th>ville</th><th>tel</th><th>email</th><th>Compte</th><th>mot de passe</th><th>editer</th><th>supprimer</th></tr>"
            dr = afficherClient()
            If dr.HasRows Then
                While dr.Read
                    Label1.Text &= "<tr><td>" & dr(0) & "</td><td>" & dr(1) & "</td><td>" & dr(2) & "</td><td>" & dr(3) & "</td><td>" & dr(4) & "</td><td>" & dr(5) & "</td><td>" & dr(6) & "</td><td>*******</td><td><a href='modifCLient1.aspx?id=" & dr(0) & "' class='btn btn-success'>editer</a></td><td><a href='suppClient.aspx?id=" & dr(0) & "' class='supp btn btn-danger' >supprimer</a></td></tr>"


                End While
            Else
                Label1.Text &= "<tr><td colspan='4'> Aucaun produit disponible</td></tr>"

            End If
            dr.Close()
        End If

    End Sub

End Class