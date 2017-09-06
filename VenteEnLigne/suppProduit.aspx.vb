Public Class suppProduit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else

            Dim id As Integer = Request.Params("id")
            dr = deleteProduit(id)
            dr.Close()
            Application("suppP") = 1
            Response.Redirect("gestionProduit.aspx")

        End If

    End Sub

End Class