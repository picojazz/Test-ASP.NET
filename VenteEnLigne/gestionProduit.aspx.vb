Public Class gestionProduit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()



        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else


            Label1.Text = "<table class=' table table-stripped table-hover'>"
            Label1.Text &= "<tr><th>code produit</th><th>photo</th><th>designation</th><th>prix unitaire</th><th>quantite en stock</th><th>editer</th><th>supprimer</th></tr>"
            dr = afficherProduit()
            If dr.HasRows Then
                While dr.Read
                    Label1.Text &= "<tr><td>" & dr(0) & "</td><td>----</td><td>" & dr(1) & "</td><td>" & dr(2) & "</td><td>" & dr(3) & "</td><td><a href='modifProduit.aspx?id=" & dr(0) & "' class='btn btn-success'>editer</a></td><td><a href='suppProduit.aspx?id=" & dr(0) & "' class='supp btn btn-danger' >supprimer</a></td></tr>"


                End While
            Else
                Label1.Text &= "<tr><td colspan='4'> Aucaun produit disponible</td></tr>"

            End If
            Label1.Text &= "</table>"

            dr.Close()


        End If
    End Sub

End Class