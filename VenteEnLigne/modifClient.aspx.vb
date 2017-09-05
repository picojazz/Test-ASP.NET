Imports System.Data.SqlClient
Public Class modifClient
    Inherits System.Web.UI.Page

    Dim drIn As SqlDataReader
    Dim dtin As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()
        If Session.Item("isOpen") = "" Then
            Response.Redirect("connexion.aspx")
        Else

            txtNom.Text = "<input type='text' name='nom' class='form-control' value='" & nom & "'>"
            txtAdresse.Text = "<input type='text' name='adresse' class='form-control' value='" & adresse & "'>"
            txtTel.Text = "<input type='text' name='tel' class='form-control' value='" & tel & "'>"
            txtEmail.Text = "<input type='text' name='email' class='form-control' value='" & email & "'>"
            txtCompte.Text = "<input type='text' name='compte' class='form-control' value='" & compte & "'>"
            mdp.Text = "<input type='password' name='mdp' class='form-control' value='" & passe & "'>"


        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String = Request.Form("nom")
        Dim adress As String = Request.Form("adresse")
        Dim vill As String = Request.Form("Ville")
        Dim tell As String = Request.Form("tel")
        Dim emai As String = Request.Form("email")
        Dim compt As String = Request.Form("compte")
        Dim pass As String = Request.Form("mdp")
        dr = modiffCLient(n, adress, vill, tell, emai, compt, pass)
        dr.Close()
        drIn = login(compte, passe)
        If drIn.HasRows Then
            Dim dt As New DataTable
            dt.Load(drIn)
            Session("client") = dt
            initialiserInfoClient(dt)
            Response.Redirect("infoClient.aspx")
        End If

        
    End Sub
End Class