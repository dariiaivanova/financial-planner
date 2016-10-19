using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace financialplanner.Data
{
    public class ExcelStorage : IStorage
    {
        private readonly string _file;

        public ExcelStorage(string filePath)
        {
            // clean
            _file = filePath;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private IXLWorksheet AddSheet(XLWorkbook book, string sheetName, List<string> namesofColumns, bool bookCreated)
        {
            // add sheet
            var worksheet = book.Worksheets.Add(sheetName);
            worksheet.ColumnWidth = 20;
            int numofColumns = namesofColumns.Count();
            for (int i = 0; i < numofColumns; i++)
            {
                worksheet.Cell(1, i + 1).Value = namesofColumns[i];
            }

            return worksheet;
        }

        public IRecordBuilder AddRecord(IWritable obj)
        {
            var bookCreated = !File.Exists(_file);
            var book = bookCreated ? new XLWorkbook() : new XLWorkbook(_file);
            IXLWorksheet sheet;
            if (!book.Worksheets.TryGetWorksheet(obj.StorageName(), out sheet))
            {
                sheet = AddSheet(book, obj.StorageName(), obj.ColumnNames(), bookCreated);
            }
            var row = sheet.RowsUsed().Count() + 1;

            return new ExcelRecordBuilder(row, book, sheet, _file, bookCreated);
        }
    }

    public class ExcelRecordBuilder : IRecordBuilder
    {
        private readonly string _file;
        private readonly bool _bookCreated;
        private readonly XLWorkbook _book;
        private readonly IXLWorksheet _sheet;
        private readonly int _row;
        private int _cell = 1;

        public ExcelRecordBuilder(int row, XLWorkbook book, IXLWorksheet sheet, string file, bool bookCreated)
        {
            _row = row;
            _sheet = sheet;
            _book = book;
            _file = file;
            _bookCreated = bookCreated;
        }

        public IRecordBuilder AddValue(string value)
        {
            _sheet.Cell(_row, _cell++).SetValue(value);
            return this;
        }

        public void Write()
        {
            if (_bookCreated)
            {
                _book.SaveAs(_file);
            }
            else
            {
                _book.Save();
            }
        }
    }
}


