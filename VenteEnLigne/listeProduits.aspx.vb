Imports System.Data.SqlClient
Public Class listeProduits
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()



        If Session.Item("isOpen") = "" Then
            Response.Redirect("connexion.aspx")
        Else
            Dim drnp As SqlDataReader
            Application("count") += 1
            Label1.Text = "<table class=' table table-stripped table-hover'>"
            Label1.Text &= "<tr><th>code produit</th><th>photo</th><th>designation</th><th>prix unitaire</th><th>quantite en stock</th><th>voir</th></tr>"
            dr = afficherProduit()
            If dr.HasRows Then
                While dr.Read
                    Label1.Text &= "<tr><td>" & dr(0) & "</td><td><img src='" & dr(4) & "' width ='50px' height='50px'  ></td><td>" & dr(1) & "</td><td>" & dr(2) & "</td><td>" & dr(3) & "</td><td><a class='btn btn-primary voir' data-toggle='modal' href='#modal-id'>voir</a></td></tr>"


                End While
            Else
                Label1.Text &= "<tr><td colspan='4'> Aucaun produit disponible</td></tr>"

            End If
            Label1.Text &= "</table>"

            dr.Close()
            drnp = nbProd()


            If drnp.Read Then
                Label2.Text = "Nombre total de produits : " & drnp(0)
            End If

            drnp.Close()


            Label3.Text = " visites : " & Application("count")


        End If


    End Sub

End Class