Imports System.Data.SqlClient
Public Class gestionCommande
    Inherits System.Web.UI.Page

    Dim dr2 As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()

        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else

            dr = commandeAll()
            If dr.HasRows Then
                While dr.Read
                    Label1.Text &= "<tr><td>" & dr(0) & "</td><td>" & dr(1) & "</td><td>" & dr(2) & "</td><td>" & dr(3) & "</td><td>" & dr(4) & "</td><td>" & dr(5) & "</td><td>" & dr(6) & "</td><td>" & dr(7) & "</td><td>" & dr(8) & "</td></tr>"


                End While
            Else
                Label1.Text &= "<tr><td colspan='5'> Aucune commande disponible</td></tr>"

            End If
            dr.Close()


        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim de As String = Request.Form("de")
        Dim a As String = Request.Form("a")
        dr2 = commandePeriode(de, a)
        Label1.Text = ""
        If dr2.HasRows Then
            While dr2.Read
                Label1.Text &= "<tr><td>" & dr2(0) & "</td><td>" & dr2(1) & "</td><td>" & dr2(2) & "</td><td>" & dr2(3) & "</td><td>" & dr2(4) & "</td><td>" & dr2(5) & "</td><td>" & dr2(6) & "</td><td>" & dr2(7) & "</td><td>" & dr2(8) & "</td></tr>"


            End While
        Else
            Label1.Text &= "<tr><td colspan='5'> Aucune commande disponible</td></tr>"

        End If
        dr2.Close()
    End Sub
End Class