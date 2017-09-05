Imports System.Web.SessionState
Imports System.Data.SqlClient

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Dim drLast As SqlDataReader

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        drLast = lastNbVisite()
        If drLast.Read Then
            Application("count") = drLast(0)
        End If

        drLast.Close()

        Application("str") = 0
        Application("logout") = 0
        Application("modif") = 0
        Application("supp") = 0

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started

    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends


    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

        updateNbVisite(Application("count"))

    End Sub

End Class