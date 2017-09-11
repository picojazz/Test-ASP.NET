Imports System.Data.SqlClient
Public Class modifClient1
    Inherits System.Web.UI.Page


    Dim dr2 As SqlDataReader
    Dim mat As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()

        If Session.Item("isOpen") = "" Or Session("admin") <> "99" Then
            Response.Redirect("adminConnexion.aspx")
        Else
            mat = Request.Params("id")
            dr = Client(mat)
            If dr.Read() Then
                txtNom.Text = "<input type='text' name='nom' class='form-control' value='" & dr(1) & "'>"
                txtAdresse.Text = "<input type='text' name='adresse' class='form-control' value='" & dr(2) & "'>"
                txtTel.Text = "<input type='text' name='tel' class='form-control' value='" & dr(4) & "'>"
                txtEmail.Text = "<input type='text' name='email' class='form-control' value='" & dr(5) & "'>"
                txtCompte.Text = "<input type='text' name='compte' class='form-control' value='" & dr(6) & "'>"
                mdp.Text = "<input type='password' name='mdp' class='form-control' value='" & dr(7) & "'>"
                lst.SelectedValue = dr(3)
            End If
            dr.Close()
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String = Request.Form("nom")
        Dim adress As String = Request.Form("adresse")
        Dim vill As String = Request.Form("lst")
        Dim tell As String = Request.Form("tel")
        Dim emai As String = Request.Form("email")
        Dim compt As String = Request.Form("compte")
        Dim pass As String = Request.Form("mdp")
        dr2 = modiffCLient1(n, adress, vill, tell, emai, compt, pass, mat)
        dr2.Close()
        Application("modif") = 1
        Response.Redirect("gestionClient.aspx")

    End Sub
End Class