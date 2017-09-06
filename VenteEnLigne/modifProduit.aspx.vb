Imports System.Data.SqlClient
Public Class modifProduit
    Inherits System.Web.UI.Page

    Dim codeProd As Integer
    Dim dr2 As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()



        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else
            codeProd = Request.Params("id")
            dr = produit(codeProd)
            If dr.Read() Then
                codeP.Text = "<p>" & dr(0) & "</p> "
                des.Text = "<input type='text' name='des' class='form-control' value='" & dr(1) & "'>"
                pu.Text = "<input type='number' name='pu' class='form-control' value='" & dr(2) & "'>"
                qte.Text = "<input type='number' name='qte' class='form-control' value='" & dr(3) & "'>"
            End If
            dr.Close()

        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desi As String = Request.Form("des")
        Dim prixU As String = Request.Form("pu")
        Dim quantite As String = Request.Form("qte")
        dr2 = modiffProduit(desi, prixU, quantite, codeProd)
        dr2.Close()
        Application("modifP") = 1
        Response.Redirect("gestionProduit.aspx")
    End Sub
End Class