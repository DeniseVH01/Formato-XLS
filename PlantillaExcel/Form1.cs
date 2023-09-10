using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel=Microsoft.Office.Interop.Excel;

namespace PlantillaExcel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.MostrarTabla(DGVtabla);
        }

        private void BTNexcel_Click(object sender, EventArgs e)
        {
            
             if (DGVtabla.Rows.Count > 0)
             {

                 string filePath = "C:\\Users\\denis\\OneDrive\\Documentos\\9Semestre\\PlantillaExcel\\PlantillaExcel\\bin\\Debug\\ExcelPlantilla - copia.xlsx";
                 Excel.Application ExcelApp = new Excel.Application();
                 Workbook wb;
                 Worksheet ws;
                 wb = ExcelApp.Workbooks.Open(filePath);
                 ws = wb.Worksheets[1];

                 for (int i = 0; i < DGVtabla.Rows.Count-1; i++)
                 {
                    
                    for (int j = 0; j < DGVtabla.Columns.Count; j++)
                     {
                        
                         ExcelApp.Cells[i + 10, j + 3] = DGVtabla.Rows[i].Cells[j].Value;
                        ws.Columns[4].AutoFit();
                        ws.Columns[5].AutoFit();
                        ws.Columns[6].AutoFit();
                        ws.Columns[7].AutoFit();
                        ws.Columns[8].AutoFit();
                        ws.Columns[9].AutoFit();
                    }
                   
                 }

                 for(int i=0; i < DGVtabla.Rows.Count-1; i++)
                {
                    ExcelApp.Cells[i + 10, 2] = i+1;
                }
                 MessageBox.Show("EXCEL CREADO EXITOSAMENTE");
                 ExcelApp.Visible = true;
                SaveFileDialog dialogo = new SaveFileDialog();
                if (dialogo.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
        }
    }
}
