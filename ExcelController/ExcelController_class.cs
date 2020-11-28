using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelController
{
    class ExcelController_class
    {
        private string ExcelPath;
        private Excel.Application oXL;
        private Excel._Workbook oWB;
        private Excel._Worksheet oSheet;
        //private Excel.Range oRng;

        public ExcelController_class(string excel_path)
        {
            ExcelPath = excel_path;
            // 유효성 검사

        }

        public void ShowPath()
        {
            Console.WriteLine("Path : {0}", ExcelPath);
        }

        public void OpenExcel()
        {
            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;
                oWB = oXL.Workbooks.Open(Filename: ExcelPath);
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }
        public void CloseExcel()
        {
            if (oXL == null) { return; }
            oWB.Close();
            oXL.Quit();

        }

        public void WriteSomething(string something)
        {
            oSheet = oWB.ActiveSheet;
            oSheet.Cells[1, 1].Value = "1,1 위치 쓰기";
            oSheet.Cells[1, 2].Value = something;
        }
    }
}
