Imports System.Data.SqlClient
Public Class doCommande
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()
        If Session.Item("isOpen") = "" Then
            Response.Redirect("connexion.aspx")
        Else

            Dim drp As SqlDataReader
            Dim drp1 As SqlDataReader

            drp = afficherProduit()
            Label1.Text = "<select name='codeProd' class='form-control'>"
            If drp.HasRows Then
                While drp.Read
                    Label1.Text &= "<option value='" & drp(0) & "'>" & drp(1) & "</option>"
                End While
                Label1.Text &= "</select>"

            End If
            drp.Close()
            drp1 = afficherProduit()

            Label2.Text = "<input type='number' name='qte' class='form-control' >"

            Label4.Text = "<table class=' table table-stripped table-hover'>"
            Label4.Text &= "<tr><th>code produit</th><th>designation</th><th>prix unitaire</th><th>quantite en stock</th><th>commander</th></tr>"

            If drp1.HasRows Then
                While drp1.Read
                    Label4.Text &= "<tr><td>" & drp1(0) & "</td><td>" & drp1(1) & "</td><td>" & drp1(2) & "</td><td>" & drp1(3) & "</td><td><a class='btn btn-success voir' data-toggle='modal' href='#modal-id'>Commander</a></td></tr>"


                End While
            Else
                Label4.Text &= "<tr><td colspan='4'> Aucaun produit disponible</td></tr>"

            End If
            Label4.Text &= "</table>"

            drp1.Close()
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim drajCom As SqlDataReader
        Dim codeProd As Integer = Request.Form("codeProd")
        Dim qte As Integer = Request.Form("qte")
        Dim desc As String = ""
        'MsgBox(Date.Now)
        drajCom = ajoutCommande(codeProd, qte, desc)
        drajCom.Close()

        Label3.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Commande enregistrer avec succee !!!</div>"
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim drajCom1 As SqlDataReader
        Dim codeProd As Integer = Request.Form("codePro")
        Dim qte As Integer = Request.Form("qte1")
        Dim desc As String = Request.Form("desc")
        'MsgBox(Date.Now)
        drajCom1 = ajoutCommande(codeProd, qte, desc)
        drajCom1.Close()

        Label3.Text = "<div class='alert alert-success'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>Commande enregistrer avec succee !!!</div>"
    End Sub
End Class