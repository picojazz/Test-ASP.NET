Public Class rechProd
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("isOpen") = "" Then
            Response.Redirect("connexion.aspx")
        Else
            Dim codeProd As Integer = Val(Request.QueryString.Get("id"))
            dr = rechProduit(codeProd)
            If dr.HasRows Then
                If dr.Read Then
                    Response.Write("<div class='form-group'><label>Quantite :</label><input type='number' class='form-control' name='qte1' ><input type='text' name='codeProd1' value='" & dr(1) & "' ></div>")
                    Response.Write("<div class='form-group'><label>description :</label><textarea class='form-control' name='desc'></textarea></div>")
                End If

            End If


            dr.Close()

            End If



    End Sub

End Class