Imports System.Data.SqlClient
Public Class listeCommande
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()
        If Session.Item("isOpen") = "" Then
            Response.Redirect("connexion.aspx")
        Else
            Dim drCom As SqlDataReader
            Dim drTot As SqlDataReader

            drCom = MesCommandes()
            If drCom.HasRows Then
                While drCom.Read
                    Label1.Text &= "<tr><td>" & drCom(5) & "</td><td>" & drCom(0) & "</td><td>" & drCom(1) & "</td><td>" & drCom(2) & "</td><td>" & drCom(3) & "</td><td>" & drCom(4) & "</td><td>" & drCom(6) & "</td></tr>"


                End While
            Else
                Label1.Text &= "<tr><td colspan='5'> Aucune commande disponible</td></tr>"

            End If


            drCom.Close()
            drTot = montant()
            'If drTot.Read Then
            '    Label2.Text = "<h3 class='text-center'>Somme Total des commandes : <span class='text-primary'>" & drTot(0) & " FCFA</span></h3>"
            'End If
            drTot.Read()
            Label2.Text = "<h3 class='text-center'>Somme Total des commandes : <span class='text-primary'>" & drTot(0) & " FCFA</span></h3>"
            drTot.Close()



        End If
    End Sub

End Class