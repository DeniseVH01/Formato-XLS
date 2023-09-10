Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As ConexionVB = New ConexionVB()
        c.MostrarTabla(DGVtabla)
    End Sub

    Private Sub BTNexcel_Click(sender As Object, e As EventArgs) Handles BTNexcel.Click
        If DGVtabla.Rows.Count > 0 Then
            Dim filePath As String = "C:\Users\denis\OneDrive\Documentos\9Semestre\PlantillaExcel\PlantillaExcelVB\bin\Debug\ExcelPlantilla - copia.xlsx"
            Dim ExcelApp As Excel.Application = New Excel.Application()
            Dim wb As Workbook
            Dim ws As Worksheet
            wb = ExcelApp.Workbooks.Open(filePath)
            ws = wb.Worksheets(1)

            For i As Integer = 0 To DGVtabla.Rows.Count - 1 - 1

                For j As Integer = 0 To DGVtabla.Columns.Count - 1
                    ExcelApp.Cells(i + 10, j + 3) = DGVtabla.Rows(i).Cells(j).Value
                    ws.Columns(4).AutoFit()
                    ws.Columns(5).AutoFit()
                    ws.Columns(6).AutoFit()
                    ws.Columns(7).AutoFit()
                    ws.Columns(8).AutoFit()
                    ws.Columns(9).AutoFit()
                Next
            Next

            For i As Integer = 0 To DGVtabla.Rows.Count - 1 - 1
                ExcelApp.Cells(i + 10, 2) = i + 1
            Next

            MessageBox.Show("EXCEL CREADO EXITOSAMENTE")
            ExcelApp.Visible = True
            Dim dialogo As SaveFileDialog = New SaveFileDialog()

            If dialogo.ShowDialog() <> DialogResult.OK Then
                Return
            End If
        End If
    End Sub
End Class
