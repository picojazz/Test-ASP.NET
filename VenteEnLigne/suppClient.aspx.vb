﻿Public Class suppClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else

            Dim mat As Integer = Request.Params("id")
            dr = deleteClient(mat)
            dr.Close()
            Application("supp") = 1
            Response.Redirect("gestionClient.aspx")
        End If


    End Sub

End Class