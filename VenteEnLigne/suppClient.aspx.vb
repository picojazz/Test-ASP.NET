Public Class suppClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mat As Integer = Request.Params("id")
        dr = deleteClient(mat)
        dr.Close()
        Application("supp") = 1
        Response.Redirect("gestionClient.aspx")


    End Sub

End Class