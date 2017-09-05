Public Class infoClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
        Response.Cache.SetNoStore()

        If Session.Item("isOpen") = "" Then
            Response.Redirect("connexion.aspx")
        Else


            Dim dt As DataTable = Session("client")
            initialiserInfoClient(dt)
            Label1.Text = "<label class='text-primary'>" & mat & "</label>"
            Label2.Text = "<label class='text-primary'>" & nom & "</label>"
            Label3.Text = "<label class='text-primary'>" & adresse & "</label>"
            Label4.Text = "<label class='text-primary'>" & ville & "</label>"
            Label5.Text = "<label class='text-primary'>" & tel & "</label>"
            Label6.Text = "<label class='text-primary'>" & email & "</label>"
            Label7.Text = "<label class='text-primary'>" & compte & "</label>"


        End If


    End Sub

End Class