Imports Oracle.ManagedDataAccess.Client
Imports Microsoft.Reporting.WebForms
Imports System.Data.SqlClient
Public Class About
    Inherits Page
    Dim FF As New csConnOracle
    Dim conString = ConfigurationManager.ConnectionStrings("RDLCConn").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oradb As String = FF.GetConn("MMNEW")
        Dim conn As New OracleConnection(oradb)
        conn.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT CUST_CODE||CUST_NAME CUST_CODE FROM OM_CUSTOMER WHERE CUST_CODE LIKE('MCB-%')"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While (dr.Read())
            ListBox1.Items.Add(dr.Item("CUST_CODE"))
        End While
        conn.Dispose()
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ReportViewer1.Visible = True
        ReportViewer1.ProcessingMode = ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report/test.rdlc")
        Dim dsitems As New DataSet
        dsitems = getData()
        Dim datasource = New ReportDataSource("DataSet1", dsitems.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.Focus()
    End Sub
    Public Function getData() As DataSet
        Dim cmd As New SqlCommand()
        cmd = New SqlCommand("SELECT * FROM OT_INVOICE_ITEM WHERE R_Y_M = '2020/06'")
        Using con As New SqlConnection(conString)
            Using sda As New SqlDataAdapter()
                cmd.Connection = con
                sda.SelectCommand = cmd
                Using dsitems As New DataSet()
                    sda.Fill(dsitems)
                    Return dsitems
                End Using
            End Using
        End Using
    End Function

End Class