Imports System.Data.SqlClient

Module traitement

    Public conn As New SqlConnection("server=(local);initial catalog=VenteEnLigne;integrated security=true")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public nom As String
    Public adresse As String
    Public tel As String
    Public email As String
    Public compte As String
    Public ville As String
    Public mat As String
    Public passe As String

    Public Sub initialiserInfoClient(ByVal dt As DataTable)
        mat = dt.Rows(0)(0)
        nom = dt.Rows(0)(1)
        adresse = dt.Rows(0)(2)
        ville = dt.Rows(0)(3)
        tel = dt.Rows(0)(4)
        email = dt.Rows(0)(5)
        compte = dt.Rows(0)(6)
        passe = dt.Rows(0)(7)


    End Sub



    Public Sub ouvrirConn()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
    End Sub

    Public Sub fermerConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function executeSQL(ByVal req As String, Optional ByVal type As String = "r")
        ouvrirConn()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = req
        cmd.Connection = conn

        If type = "r" Then
            Return cmd.ExecuteReader
        Else
            Return cmd.ExecuteNonQuery
        End If
    End Function

    Public Function ajoutCLient(ByVal nom As String, ByVal adresse As String, ByVal ville As String, ByVal tel As String, ByVal email As String, ByVal compte As String, ByVal passe As String)
        Return executeSQL("insert into client values('" & nom & "','" & adresse & "','" & ville & "','" & tel & "','" & email & "','" & compte & "','" & passe & "')")


    End Function

    Public Function login(ByVal compte As String, ByVal passe As String)

        Return executeSQL("select * from client where compte ='" & compte & "' and motdepasse='" & passe & "'")
    End Function

    Public Function afficherProduit()

        Return executeSQL("select * from produit")
    End Function

    Public Function nbProd()
        Return executeSQL("select count(*) from produit")

    End Function
    Public Function updateNbVisite(ByVal nb As Integer)
        Return executeSQL("update visite set nvisite =" & nb & "")

    End Function
    Public Function lastNbVisite()
        Return executeSQL("select top 1 * from visite")

    End Function

    Public Function ajoutCommande(ByVal codeProd As Integer, ByVal qte As Integer, ByVal des As String)
        Return executeSQL("insert into commande values('" & Date.Now & "'," & mat & "," & codeProd & "," & qte & ",'" & des & "')")


    End Function

    Public Function MesCommandes()
        Return executeSQL("select c.datecom,p.designation , p.prixunit,c.qtecom,(p.prixunit*c.qtecom),c.numcom,c.[desc] from produit p ,commande c where p.numprod = c.numprod and c.matricule = " & mat & "")

    End Function
    Public Function montant()
        Return executeSQL("select sum(p.prixunit*c.qtecom) from produit p ,commande c where p.numprod = c.numprod and c.matricule = " & mat & "")

    End Function
    Public Function rechProduit(ByVal codeProd As Integer)
        Return executeSQL("select * from produit where numprod=" & codeProd & "")
    End Function

    Public Function modiffCLient(ByVal nom As String, ByVal adresse As String, ByVal ville As String, ByVal tel As String, ByVal email As String, ByVal compte As String, ByVal passe As String)
        Return executeSQL("update client set nom ='" & nom & "', adresse='" & adresse & "',ville ='" & ville & "',tel='" & tel & "',email='" & email & "',compte='" & compte & "',motdepasse='" & passe & "' where matricule =" & mat & "")


    End Function
    Public Function modiffCLient1(ByVal nom As String, ByVal adresse As String, ByVal ville As String, ByVal tel As String, ByVal email As String, ByVal compte As String, ByVal passe As String, ByVal id As Integer)
        Return executeSQL("update client set nom ='" & nom & "', adresse='" & adresse & "',ville ='" & ville & "',tel='" & tel & "',email='" & email & "',compte='" & compte & "',motdepasse='" & passe & "' where matricule =" & id & "")


    End Function
    Public Function afficherClient()

        Return executeSQL("select * from client")
    End Function
    Public Function deleteClient(ByVal id As Integer)

        Return executeSQL("delete client where matricule =" & id & "")
    End Function
    Public Function deleteProduit(ByVal id As Integer)

        Return executeSQL("delete produit where numprod =" & id & "")
    End Function
    Public Function Client(ByVal id As Integer)

        Return executeSQL("select * from client where matricule =" & id & "")
    End Function
    Public Function produit(ByVal id As Integer)

        Return executeSQL("select * from produit where numprod =" & id & "")
    End Function
    Public Function modiffProduit(ByVal des As String, ByVal pu As String, ByVal qte As String, ByVal id As Integer)
        Return executeSQL("update produit set designation ='" & des & "', prixunit='" & pu & "',qtestock ='" & qte & "' where numprod =" & id & "")


    End Function




End Module
