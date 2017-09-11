Public Class gestionProduit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()

        If Application("modifP") = 1 Then
            Label2.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Produit modifié</div>"
            Application("modifP") = 0
        ElseIf Application("suppP") = 1 Then
            Label2.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Produit supprimé</div>"
            Application("suppP") = 0
        Else
            Label2.Text = ""
        End If


        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else


            Label1.Text = "<table class=' table table-stripped table-hover'>"
            Label1.Text &= "<tr><th>code produit</th><th>photo</th><th>designation</th><th>prix unitaire</th><th>quantite en stock</th><th>editer</th><th>supprimer</th></tr>"
            dr = afficherProduit()
            If dr.HasRows Then
                While dr.Read
                    Label1.Text &= "<tr><td>" & dr(0) & "</td><td><a class=' voir' data-toggle='modal' href='#modal-id'><img src='" & dr(4) & "' width ='50px' height='50px'  ></a></td><td>" & dr(1) & "</td><td>" & dr(2) & "</td><td>" & dr(3) & "</td><td><a href='modifProduit.aspx?id=" & dr(0) & "' class='btn btn-success'>editer</a></td><td><a href='suppProduit.aspx?id=" & dr(0) & "' class='supp btn btn-danger' >supprimer</a></td></tr>"


                End While
            Else
                Label1.Text &= "<tr><td colspan='4'> Aucaun produit disponible</td></tr>"

            End If
            Label1.Text &= "</table>"

            dr.Close()


        End If
    End Sub

End Class