using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;

namespace TimeSpenderDjan
{
    internal class ExcelReadClass
    {
        private _Application excel = new Application();
        private Workbook workbook;
        private Worksheet workSheet;

        public ExcelReadClass NewFile()
        {
            workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            workSheet = workbook.Worksheets[1];

            // Return itself so i can daisychain these commands when called
            return this;
        }

        public List<string> readFileData(string filepath)
        {
            workbook = excel.Workbooks.Open(filepath);
            workSheet = workbook.ActiveSheet;

            List<string> data = new List<string>();
            // Row indices start at 1 not 0.
            int i = 1;

            while (true)
            {
                var cellData = workSheet.Cells[i, 1].Value;
                // Stop if we found an empty cell
                if (cellData == null)
                {
                    break;
                }

                // Convert to string after null check else it would crash
                cellData = cellData.ToString();

                data.Add(cellData);
                i++;
            }

            return data;
        }

        public ExcelReadClass StoreDataAsList(string[] data)
        {
            // Print the data in the first column on a seperatre row
            for (int i = 0; i < data.Length; i++)
            {
                workSheet.Cells[i + 1, 1].Value = data[i];
            }

            return this;
        }

        public ExcelReadClass SaveAs(string path)
        {
            workbook.SaveAs(path); //saves state of the excel sheet
            return this;
        }

        public void Close()
        {
            workbook.Close();
        }
    }
}