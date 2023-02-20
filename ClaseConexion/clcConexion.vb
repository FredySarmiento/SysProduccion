Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Collections



Public Class ClcConexion
    Public oConexion As New OleDb.OleDbConnection
    Dim strConexion As String

    '  Private Const strConexion = "Provider=Microsoft.Jet.OleDB.4.0;Data Source = \vbesko\SysData.mdb"
    ' Private Const strConexion = "Provider=Microsoft.Jet.OleDB.4.0;Data Source = "
    Private Const vl_sNomBDCnf = "SysConfig.mdb"

    'Private Const strConexion = "Provider=Microsoft.Jet.OleDB.4.0;Data Source = \\servidor\siles\SysData.mdb"
    Public oConexionODBC As New Odbc.OdbcConnection
    Private Const sConexionODBC = "dsn=sysdata"

    Public Function CcConectarBD()
        'Fec_Ult_Act: 2014.05.06
        strConexion = ""
        Dim wl_bYesNo As Boolean
        Try
            wl_bYesNo = ccLeePath()
            wl_bYesNo = ccLeeBD()
            oConexion = New OleDb.OleDbConnection()
            oConexion.ConnectionString = strConexion

            If oConexion.State = ConnectionState.Closed Then
                oConexion.Open()
            End If

            Return True
        Catch ex As Exception
            oConexion.Close()
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccConectarBD " & oConexion.State.ToString)
            Return False
        End Try
    End Function
    Public Function CcConectarBDConfig()
        'Fec_Ult_Act: 2014.05.06
        strConexion = ""
        Dim wl_bYesNo As Boolean

        Try
            wl_bYesNo = ccLeePath()
            wl_bYesNo = ccLeeCnf(vl_sNomBDCnf)

            oConexion = New OleDb.OleDbConnection()
            oConexion.ConnectionString = strConexion
            If Not oConexion.State = ConnectionState.Open Then
                oConexion.Open()
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccConectarBDConfig ")
            Return False
        End Try
    End Function
    Public Function CcConectarODBC()
        Try
            oConexionODBC = New Odbc.OdbcConnection
            oConexionODBC.ConnectionString = sConexionODBC
            If Not oConexionODBC.State = ConnectionState.Open Then
                oConexionODBC.Open()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccConectarODBC ")
            Return False
        End Try
    End Function
    Public Function CcDesconectarBD()
        Try
            If oConexion.State <> ConnectionState.Closed Then
                oConexion.Dispose()
                oConexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            oConexion.Close()
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccDesconectarBD ")
            Return False
        End Try
    End Function
    Public Function CcDesconectarODBC()
        Try
            If oConexionODBC.State = ConnectionState.Open Then
                oConexionODBC.Close()
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccDesconectarODBC ")
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function CcLeePath() As Boolean
        'Fec_Ult_Mod:  2014.05.06

        Try
            ' Dim oReader As New StreamReader("\vbesko\SilesConfig.txt")
            Dim oReader As New StreamReader("SilesConfig.txt")
            Dim wl_sCad As String = ""
            Dim wl_asCad As New ArrayList
            Do
                wl_sCad = oReader.ReadLine()
                If Not wl_sCad Is Nothing Then
                    wl_asCad.Add(wl_sCad)
                End If
            Loop Until wl_sCad Is Nothing
            oReader.Close()

            wl_sCad = Trim(wl_asCad(0))

            ' strConexion = "Provider=Microsoft.Jet.OleDB.4.0;Data Source = "
            strConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " 'para access 2007


            strConexion += (wl_sCad)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccLeePath ")
        End Try
        Return Nothing
    End Function
    Public Function CcLeeCnf(ByVal wp_sNomBDCng As String) As Boolean
        Try
            strConexion += Trim(wp_sNomBDCng)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccLeeCnf ")

        End Try

        Return Nothing

    End Function

    Public Function CcLeeBD() As Boolean
        ' Dim oReader As New StreamReader("\vbesko\NomBD.txt")
        Try
            Dim oReader As New StreamReader("NomBD.txt")
            Dim wl_sCad As String = ""
            Dim wl_asCad As New ArrayList
            Do
                wl_sCad = oReader.ReadLine()
                If Not wl_sCad Is Nothing Then
                    wl_asCad.Add(wl_sCad)
                End If
            Loop Until wl_sCad Is Nothing
            oReader.Close()

            wl_sCad = Trim(wl_asCad(0))
            strConexion += Trim(wl_sCad)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccLeeBD ")
        End Try
        Return Nothing
    End Function
    Public Function CcClose() As Boolean
        Try
            oConexion.Close()
            oConexion.Dispose()
            ' oConexion = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clcConexion.ccClose ")
        End Try
        Return True
    End Function
End Class
