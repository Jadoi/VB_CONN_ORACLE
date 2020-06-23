Imports Oracle.ManagedDataAccess.Client
Public Class csConnOracle
    Private ConnMMNEW As String = "User Id=MMNEW;Password=MMNEW;Data Source=192.168.1.7:1521/orcl;"
    Private ConnMMTEST As String = "User Id=MMNEW;Password=MMNEW;Data Source=192.168.1.7:1521/orcl;"
    Private ConnRDLC As String = "Data Source=192.168.13.15;Initial Catalog=RDLC;USER ID = sa;Password=orion_1024"
    Public Function GetConn(ByVal valueConn As String) As String
        Dim Rt As String
        If (valueConn = "MMNEW") Then
            Rt = ConnMMNEW
        ElseIf (valueConn = "MMTEST") Then
            Rt = ConnMMTEST
        ElseIf (valueConn = "RDLC") Then
            Rt = ConnRDLC
        End If
        Return Rt
    End Function
End Class
