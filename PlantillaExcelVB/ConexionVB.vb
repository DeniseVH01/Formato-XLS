Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class ConexionVB
    Private cn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private da As SqlDataAdapter
    Private dt As DataTable

    Public Sub New()
        Try
            cn = New SqlConnection("Data Source=LAPTOP-RNN6MELF\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True")
            cn.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("No se conecto con la base de datos" & ex.ToString())
        End Try
    End Sub

    Public Sub MostrarTabla(ByVal dgv As DataGridView)
        Try
            da = New SqlDataAdapter("Select top 50 CustomerID,OrderDate,ShippedDate,ShipVia,Freight,ShipName from Orders", cn)
            dt = New DataTable()
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se pudo llenar el data grid view" & ex.ToString())
        End Try
    End Sub
End Class
