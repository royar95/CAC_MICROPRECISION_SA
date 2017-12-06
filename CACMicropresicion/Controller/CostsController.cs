using CACMicropresicion.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACMicropresicion.Controller
{
    class CostsController : BaseController
    {
        public Dictionary<Object, dynamic> data { get; set; }

        public CostsController() { }

        public Dictionary<Object, dynamic> getCosts()
        {
            try
            {

                DateTime startDate = data["startDate"];
                DateTime endDate = data["endDate"];

                var query = from costs in db.Compra
                            where costs.IdEstado == Status.Paid || costs.IdEstado == Status.WaitingForPayment
                            where costs.FechaCompra >= startDate
                            where costs.FechaCompra <= endDate
                            orderby costs.FechaCompra
                            select new
                            {
                                costs.FechaCompra,
                                costs.IdCompra,
                                costs.TotalCompra
                            };
                var sale = query.ToList();
                return result(Result.Processed, null, sale);

            }
            catch (Exception ex)
            {
                return result(Result.Failed, "Error al extraer los datos: " + ex.Message, null);
            }

        }


        public void ExportToExcel(DataGridView dgCosts)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Reporte De Compras";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i <= dgCosts.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgCosts.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgCosts.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgCosts.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Guardado Satisfactoriamente");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }


        }
}
