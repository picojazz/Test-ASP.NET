Imports System.Data.SqlClient

Public Class inscription
    Inherits System.Web.UI.Page

    Dim drIns As SqlDataReader


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Dim nom As String = Request.Form("txtNom")
        Dim adress As String = Request.Form("txtAdresse")
        Dim ville As String = Request.Form("Ville")
        Dim tel As String = Request.Form("txtTel")
        Dim email As String = Request.Form("txtEmail")
        Dim compte As String = Request.Form("txtCompte")
        Dim passe As String = Request.Form("txtPasse")
        drIns = ajoutCLient(nom, adress, ville, tel, email, compte, passe)
        drIns.Close()
        Application("str") = 1
        Response.Redirect("connexion.aspx")







    End Sub
End Class