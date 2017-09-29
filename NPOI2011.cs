using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
//using System.Web.Security;
//using System.Xml.Linq;
using System.IO;
using System.Collections;

using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;
using NPOI.SS.Util;


namespace CostErrDeal
{
    /// <summary>
    ///Daniel 2011/11/09
    ///利用NPOI導出及讀入Excel資料
    /// </summary>
    public class NPOI2011
    {

        private HSSFWorkbook _myExcelWB;
        private HSSFSheet _myExcelST;

        public HSSFWorkbook myExcelWBA;
        public HSSFSheet myExcelST;

        private int _intST=0;
        public int intST
        {
            get
            {
                _intST = _myExcelWB.ActiveSheetIndex;
                return _intST; 
            }
            set
            {
                _intST = value;
                _myExcelST = (HSSFSheet)_myExcelWB.GetSheetAt(_intST);
                _myExcelWB.SetActiveSheet(_intST);
                myExcelST = _myExcelST;
                //return _intST;

            }
        }

        private bool _AutoNoFlag=false;
        public bool AutoNoFlag
        {
            get { return _AutoNoFlag; }
            set { _AutoNoFlag = value; }
        }

        public NPOI2011(string strPath)
        {
            if (strPath == "")
            {
                _myExcelWB = new HSSFWorkbook();        ///如果strPath="",表示创建一个空的WorkBook对象
                _myExcelST =(HSSFSheet) _myExcelWB.CreateSheet("Sheet1");
            }

            else
            {
                _myExcelWB = new HSSFWorkbook(new FileStream(strPath, FileMode.Open, FileAccess.Read));
                _myExcelST = (HSSFSheet)_myExcelWB.GetSheetAt(0);
            }


            //create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";                        
            _myExcelWB.DocumentSummaryInformation = dsi;            

            //create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            _myExcelWB.SummaryInformation = si;

            myExcelST = _myExcelST;
            myExcelWBA = _myExcelWB;
        }

        public void CreateSheets(int intCount)
        {
            if (intCount > 1)
            {
                for (int i = 1; i < intCount; i++)
                {
                    _myExcelWB.CreateSheet();
                   
                }

                for (int i = 0; i < _myExcelWB.NumberOfSheets; i++)
                {
                    _myExcelWB.SetSheetName(i, "ST" + (i + 1).ToString());

                }
            }

        }
        public Boolean SaveXls(string strPath)
        {
            try
            {
                FileStream file = new FileStream(strPath, FileMode.Create);
                _myExcelWB.Write(file);
                file.Close(); file = null;

                return true;
            }
            catch (Exception ex)
            { return false; }

        }

        public HSSFSheet GetSheetByIndex(int SheetIndex)
        {
            return (HSSFSheet)_myExcelWB.GetSheetAt(SheetIndex);    
        }

        public string GetCellValue(string strCell,string DataType)
        {           
            CellReference myCR = new CellReference(strCell);
            ICell myCell = _myExcelST.GetRow(myCR.Row).GetCell(int.Parse(myCR.Col.ToString()));

            if (DataType.ToLower() == "datetime")
            {
                return myCell.DateCellValue.ToString();
            }
            else if (DataType.ToLower() == "numeric")
            {
                return myCell.NumericCellValue.ToString();
            }

            else
            {
                return myCell.ToString().Trim();
            }

        }

        public string GetCellValue(string strCell)
        {
            CellReference myCR = new CellReference(strCell);
            ICell myCell = _myExcelST.GetRow(myCR.Row).GetCell(int.Parse(myCR.Col.ToString()));
            
            return myCell.ToString().Trim();           

        }

        public void ExportExcelWithCaption(DataTable dt, string strCaption)
        {
            try
            {
                WriteExcelBody(dt);
                InsertRows(0, 1);
                IRow myRow = _myExcelST.GetRow(0);

                int KK = myRow.LastCellNum;

                myRow.GetCell(0).SetCellValue(strCaption);
                ICellStyle myStyle = _myExcelWB.CreateCellStyle();
                myStyle.FillForegroundColor = HSSFColor.AUTOMATIC.index;
                myStyle.FillPattern = FillPatternType.NO_FILL;

                for (int k = 0; k < KK; k++)
                { myRow.Cells[k].CellStyle = myStyle; }

                MemoryStream myMS = new MemoryStream();
                _myExcelWB.Write(myMS);

                HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=myExcel.xls"));
                HttpContext.Current.Response.BinaryWrite(myMS.GetBuffer());

                myMS = null;
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message.ToString());
            }   
        }

        public void OpenExcelFile()
        {
            MemoryStream myMS = new MemoryStream();
            _myExcelWB.Write(myMS);

            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=myExcel.xls"));
            HttpContext.Current.Response.BinaryWrite(myMS.GetBuffer());

            myMS = null;
        
        }

        public void OpenExcelFile(string strPath)
        {
            FileInfo FI = new FileInfo(strPath);
            MemoryStream myMS = new MemoryStream();
            _myExcelWB.Write(myMS);

            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=" + FI.Name + ""));
            HttpContext.Current.Response.BinaryWrite(myMS.GetBuffer());

            myMS.Close();
            myMS = null;
            FI = null;
        }

        public bool ExportExcel(DataTable dt, string strPath)
        {
            WriteExcelBody(dt);
            Boolean bk= SaveXls(strPath);

            return bk;
        }

        private void WriteExcelBody(DataTable dt)
        {
            int i, j;
            Hashtable myHT = new Hashtable();
            double myInt;
            string strDataItem;
            DateTime myDT;
            IDataFormat myFormat = _myExcelWB.CreateDataFormat();

            IFont myFont = _myExcelWB.CreateFont();
            myFont.IsItalic = true;
            myFont.FontName = "Times New Roman";
            myFont.FontHeightInPoints = 10;
            myFont.Boldweight = 700;

            ICellStyle myStyle = _myExcelWB.CreateCellStyle();
            
            myStyle.FillForegroundColor = HSSFColor.AQUA.index;
            myStyle.FillPattern = FillPatternType.SOLID_FOREGROUND;
            myStyle.BorderBottom = BorderStyle.THIN;
            myStyle.BorderLeft = BorderStyle.THIN;
            myStyle.BorderRight = BorderStyle.THIN;
            myStyle.BorderTop = BorderStyle.THIN;
            myStyle.SetFont(myFont);

            ICellStyle myGridStyle = _myExcelWB.CreateCellStyle();
            myGridStyle.BorderBottom = BorderStyle.THIN;
            myGridStyle.BorderLeft = BorderStyle.THIN;
            myGridStyle.BorderRight = BorderStyle.THIN;
            myGridStyle.BorderTop = BorderStyle.THIN;

            ICellStyle cellStyle7 = _myExcelWB.CreateCellStyle();
            //cellStyle7.DataFormat = HSSFDataFormat.GetBuiltinFormat("yyyy/m/d");
            cellStyle7.DataFormat = myFormat.GetFormat("yyyy/MM/dd");
            cellStyle7.BorderBottom = BorderStyle.THIN;
            cellStyle7.BorderLeft = BorderStyle.THIN;
            cellStyle7.BorderRight = BorderStyle.THIN;
            cellStyle7.BorderTop = BorderStyle.THIN;

            ICellStyle cellStyle8 = _myExcelWB.CreateCellStyle();
            //cellStyle7.DataFormat = HSSFDataFormat.GetBuiltinFormat("yyyy/m/d");
            cellStyle8.DataFormat = myFormat.GetFormat("HH:mm");
            cellStyle8.BorderBottom = BorderStyle.THIN;
            cellStyle8.BorderLeft = BorderStyle.THIN;
            cellStyle8.BorderRight = BorderStyle.THIN;
            cellStyle8.BorderTop = BorderStyle.THIN;

            if (_AutoNoFlag)
            {
                dt.Columns.Add("NO", Type.GetType("System.String"));
                dt.Columns["NO"].SetOrdinal(0);
            }

            IRow FirstRow = _myExcelST.CreateRow(0);
            for (j = 0; j < dt.Columns.Count; j++)
            {
                ICell myCell = FirstRow.CreateCell(j);
                myCell.CellStyle = myStyle;
                myCell.SetCellValue(dt.Columns[j].ColumnName.ToString());
            }

            for (i = 0; i < dt.Rows.Count; i++)
            {
                IRow myRow = _myExcelST.CreateRow(i + 1);
                if (_AutoNoFlag) { dt.Rows[i]["NO"] = (i + 1).ToString(); }

                for (j = 0; j < dt.Columns.Count; j++)
                {
                    ICell myCell = myRow.CreateCell(j);
                    strDataItem = dt.Rows[i][j].ToString();

                    if (DateTime.TryParse(strDataItem, out myDT))
                    {
                        if (strDataItem.Contains('/') || strDataItem.Contains('-'))
                        {
                            myCell.SetCellValue(Convert.ToDateTime(strDataItem));
                            myCell.CellStyle = cellStyle7;
                            myCell.SetCellValue(myDT);
                            if (!myHT.ContainsKey(myCell.ColumnIndex)) { myHT.Add(myCell.ColumnIndex, 0); }
                        }
                        else if (!strDataItem.Contains('/') && !strDataItem.Contains('-') && strDataItem.Contains(':') && strDataItem.Length == 5)
                        {
                            myCell.CellStyle = cellStyle8;
                            myCell.SetCellValue(myDT);
                            if (!myHT.ContainsKey(myCell.ColumnIndex)) { myHT.Add(myCell.ColumnIndex, 0); }
                        }
                        else
                        {
                            myCell.CellStyle = myGridStyle;
                            myCell.SetCellValue(Convert.ToDouble(dt.Rows[i][j].ToString()));
                        }
                        
                    }
                    else if (double.TryParse(strDataItem, out myInt))
                    {
                        myCell.CellStyle = myGridStyle;
                        myCell.SetCellValue(Convert.ToDouble(dt.Rows[i][j].ToString()));                        
                    }
                    else
                    {                       
                        myCell.CellStyle = myGridStyle;
                        myCell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                }
            }
           
            for (j = 0; j < dt.Columns.Count; j++)
                { _myExcelST.AutoSizeColumn(j);}

            if (myHT.Count > 0)
            {
                for (j = 0; j < dt.Columns.Count; j++)
                {
                    if (myHT.ContainsKey(j))
                    {
                        if (_myExcelST.GetColumnWidth(j) < 3000)
                        { _myExcelST.SetColumnWidth(j, 3000); }

                    }
                }
            }
        }

        public void ExportExcel(DataTable dt)
        {
            try
            {
                WriteExcelBody(dt);
                //AddGridLines();
                MemoryStream myMS = new MemoryStream();
                _myExcelWB.Write(myMS);

                HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=myExcel.xls"));
                HttpContext.Current.Response.BinaryWrite(myMS.GetBuffer());
                
                myMS = null;
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message.ToString());
            }            
            
        }

        public void ExportExcel(DataSet ds,string FileName)
        {
            try
            {
                int i = 0;
                foreach (DataTable dt in ds.Tables)
                {
                    _myExcelST =(HSSFSheet) _myExcelWB.GetSheetAt(i);
                    WriteExcelBody(dt);
                    i++;
                }

                if (FileName.Length == 0) { FileName = "myExcel.xls"; }

                //AddGridLines();
                MemoryStream myMS = new MemoryStream();
                _myExcelWB.Write(myMS);

                HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename="+FileName));
                HttpContext.Current.Response.BinaryWrite(myMS.GetBuffer());

                myMS = null;
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message.ToString());
            }

        }
       
        public void SetRangeValue(string strRegion, string strValue, string strFormat)
        {
            CellReference RegionA = new CellReference(strRegion);
            IDataFormat myFormat = _myExcelWB.CreateDataFormat();

            ICellStyle myCellStyle = _myExcelWB.CreateCellStyle();
            ICell myCell;

            try
            {
                myCell = _myExcelST.GetRow(RegionA.Row).GetCell(RegionA.Col);

                if (myCell == null) { myCell = _myExcelST.CreateRow(RegionA.Row).CreateCell(RegionA.Col); }
            }
            catch (Exception ex)
            { myCell = _myExcelST.CreateRow(RegionA.Row).CreateCell(RegionA.Col); }

            switch (strFormat)
            {
                case "yyyy/MM/dd":
                case "yyyy/M/d":
                case "yy/MM/dd":
                case "MM/dd":
                    { myCell.SetCellValue(Convert.ToDateTime(strValue)); break; }
                case "#,00.00":
                case "#,00.0":
                    { myCell.SetCellValue(Convert.ToDouble(strValue)); break; }
                case "#,00":
                    { myCell.SetCellValue(Convert.ToInt16(strValue)); break; }
                case "":
                    { myCell.SetCellValue(strValue); break; }
                default: break;
            }

            if (strFormat != "")
            {
                myCellStyle.DataFormat = myFormat.GetFormat(strFormat);                
                myCell.CellStyle = myCellStyle;

            }
        }

        public void SetRangeValue(string strRegion, string strValue)
        {
            SetRangeValue(strRegion, strValue, "");
        }

        public string RangeOffset(string pCell, int intRow, int intCol,string DataType)
        {
            string strCell = RangeOffsetAddress(pCell,intRow,intCol);
            return GetCellValue(strCell,DataType);  //返回偏移后的地址内容
        }

        public string RangeOffset(string pCell, int intRow, int intCol)
        {           
            string strCell = RangeOffsetAddress(pCell, intRow, intCol);
            return GetCellValue(strCell);  //返回偏移后的地址内容

        }

        public string RangeOffsetAddress(string pCell, int intRow, int intCol)
        {
            CellReference OldCellReference = new CellReference(pCell);
            CellReference TargetCellReference = new CellReference(OldCellReference.Row + intRow, OldCellReference.Col + intCol);
            string strCell = TargetCellReference.CellRefParts[2] + TargetCellReference.CellRefParts[1];
            return strCell;  //返回偏移后的地址字符串

        }

        public void InsertRows(int fromRowIndex, int rowCount)
        {
            int rowIndex, colIndex;
            IRow rowSource, rowInsert;
            ICell cellSource, cellInsert;

            _myExcelST.ShiftRows(fromRowIndex, _myExcelST.LastRowNum, rowCount);

            for (rowIndex = fromRowIndex; rowIndex < fromRowIndex + rowCount; rowIndex++)
            {
                rowSource = _myExcelST.GetRow(rowIndex + rowCount);
                rowInsert = _myExcelST.CreateRow(rowIndex);
                rowInsert.Height = rowSource.Height;
                for (colIndex = 0; colIndex < rowSource.LastCellNum + 1; colIndex++)
                {
                    cellSource = rowSource.GetCell(colIndex);
                    cellInsert = rowInsert.CreateCell(colIndex);

                    if (cellSource != null)
                    { cellInsert.CellStyle = cellSource.CellStyle; }
                }
            }
        }

        public int MergeRegion(string strCell1, string strCell2, ref ICellStyle myCellStyle)
        {            
            CellReference cellRef1 = new CellReference(strCell1);
            CellReference cellRef2 = new CellReference(strCell2);
            int KK = 0;

            CellRangeAddress region = new CellRangeAddress(cellRef1.Row, cellRef1.Col, cellRef2.Row, cellRef2.Col);
            KK = _myExcelST.AddMergedRegion(region);

            int i, j;
            for (i = cellRef1.Row; i < cellRef2.Row + 1; i++)
            {
                for (j = cellRef1.Col; j < cellRef2.Col + 1; j++)
                {
                    try
                    { _myExcelST.GetRow(i).GetCell(j).CellStyle = myCellStyle; }
                    catch (Exception ex)
                    { _myExcelST.CreateRow(i).CreateCell(j).CellStyle = myCellStyle; }
                }
            }

            return KK;
        }

        public void GridRegion(int KK)
        {
            CellRangeAddress myRegion = _myExcelST.GetMergedRegion(KK);
            int intRow1, intCol1, intRow2, intCol2;

            intRow1 = myRegion.FirstRow; intCol1 = myRegion.FirstColumn;
            intRow2 = myRegion.LastRow; intCol2 = myRegion.LastColumn;

            AddGridLines(intRow1, intCol1, intRow2, intCol2);
        }

        public void GridRegion(string strCell1, string strCell2)
        {
            CellReference CellRef1 = new CellReference(strCell1);
            CellReference CellRef2 = new CellReference(strCell2);
            int intRow1 = 0, intCol1 = 0, intRow2 = 0, intCol2 = 0;

            intRow1 = CellRef1.Row; intCol1 = CellRef1.Col;
            intRow2 = CellRef2.Row; intCol2 = CellRef2.Col;

            AddGridLines(intRow1, intCol1, intRow2, intCol2);
        }

        private void AddGridLines(int intRow1, int intCol1, int intRow2, int intCol2)
        {
            int i = 0, j = 0;
            ICellStyle myStyle = _myExcelWB.CreateCellStyle(); ;
            
            myStyle.BorderBottom = BorderStyle.THIN;
            myStyle.BorderLeft = BorderStyle.THIN;
            myStyle.BorderRight = BorderStyle.THIN;
            myStyle.BorderTop = BorderStyle.THIN;

            for (i = intRow1; i <= intRow2; i++)
            {
                for (j = intCol1; j < intCol2; j++)
                {                    
                    try
                    {   
                        _myExcelST.GetRow(i).GetCell(j).CellStyle = myStyle;
                    }
                    catch (Exception ex)
                    {   
                        _myExcelST.CreateRow(i).CreateCell(j).CellStyle = myStyle;
                    }
                }
            }
        }

        private void AddGridLines()
        {
            int i=0, j = 0; //由於後加格式會導致之前已有的格式被覆蓋,所以此代碼已棄用
            i = _myExcelST.LastRowNum; j = _myExcelST.GetRow(i).LastCellNum;
            AddGridLines(0, 0, i, j);
            _myExcelST.DisplayGridlines = false;

        }
        #region 上傳Excel文件 獲取DataTabale
        /// <summary>
        /// 用於應用程序
        /// </summary>
        /// <param name="strFilePath"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string strFilePath)
        {
            if (File.Exists(strFilePath))
            {
                FileStream myFS=new FileStream(strFilePath,FileMode.Open);
                _myExcelWB = new HSSFWorkbook(myFS);
                _myExcelST = (HSSFSheet)_myExcelWB.GetSheetAt(0);
                int rowCount = _myExcelST.LastRowNum;

                DataTable dt = new DataTable();
                if (_myExcelST != null && rowCount > 0)
                {
                    HSSFRow headerRow = (HSSFRow)_myExcelST.GetRow(0);
                    int cellCount = headerRow.LastCellNum;
                    if (headerRow != null && cellCount > 0)
                    {
                        //表頭
                        for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                        {
                            DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue.Replace(" ", ""));
                            dt.Columns.Add(column);
                        }

                        //表身
                        for (int i = (_myExcelST.FirstRowNum + 1); i <= _myExcelST.LastRowNum; i++)
                        {
                            HSSFRow row = (HSSFRow)_myExcelST.GetRow(i);
                            DataRow dataRow = dt.NewRow();

                            for (int j = row.FirstCellNum; j < cellCount; j++)
                            {
                                if (row.GetCell(j) != null)
                                {
                                    try
                                    {
                                        if (row.GetCell(j).CellType == CellType.NUMERIC)
                                        {
                                            DateTime myDT = row.GetCell(j).DateCellValue;
                                            if (myDT.Year > 1900 && myDT.Year < 2020)
                                            {
                                                dataRow[j] = myDT.ToString("yyyy/MM/dd HH:mm");
                                            }
                                            else
                                            {
                                                dataRow[j] = row.GetCell(j).ToString();
                                            }
                                        }
                                        else
                                        {
                                            dataRow[j] = row.GetCell(j).ToString();
                                        }
                                    }
                                    catch
                                    {
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                }
                            }
                            dt.Rows.Add(dataRow);
                        }

                    }

                    _myExcelWB = null;
                    _myExcelST = null;
                }
                return dt;
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// 上傳Excel文件 獲取DataTabale
        /// </summary>
        /// <param name="file"></param>
        /// <param name="startCell">起始位置</param>
        /// <param name="ReadHeader">是否需要讀取單頭</param>
        /// <returns></returns> 
        public DataTable GetDataTable(System.Web.UI.WebControls.FileUpload file)
        {
            if (file.HasFile)
            {
                _myExcelWB = new HSSFWorkbook(file.FileContent);
                _myExcelST = (HSSFSheet)_myExcelWB.GetSheetAt(0);
                int rowCount = _myExcelST.LastRowNum;

                DataTable dt = new DataTable();
                if (_myExcelST != null && rowCount > 0)
                {
                    HSSFRow headerRow = (HSSFRow)_myExcelST.GetRow(0);
                    int cellCount = headerRow.LastCellNum;
                    if (headerRow != null && cellCount > 0)
                    {
                        //表頭
                        for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                        {
                            DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue.Replace(" ",""));
                            dt.Columns.Add(column);
                        }

                        //表身
                        for (int i = (_myExcelST.FirstRowNum + 1); i <= _myExcelST.LastRowNum; i++)
                        {
                            HSSFRow row = (HSSFRow)_myExcelST.GetRow(i);
                            DataRow dataRow = dt.NewRow();

                            for (int j = row.FirstCellNum; j < cellCount; j++)
                            {
                                if (row.GetCell(j) != null)
                                {
                                    try
                                    {
                                        if (row.GetCell(j).CellType == CellType.NUMERIC)
                                        {
                                            DateTime myDT = row.GetCell(j).DateCellValue;
                                            if (myDT.Year > 1900 && myDT.Year < 2020)
                                            {
                                                dataRow[j] = myDT.ToString("yyyy/MM/dd HH:mm");
                                            }
                                            else
                                            {
                                                dataRow[j] = row.GetCell(j).ToString();
                                            }
                                        }
                                        else
                                        {
                                            dataRow[j] = row.GetCell(j).ToString();
                                        }
                                    }
                                    catch
                                    {
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                }
                            }
                            dt.Rows.Add(dataRow);
                        }

                    }

                    _myExcelWB = null;
                    _myExcelST = null;
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetDataTable(System.Web.UI.WebControls.FileUpload file, string StartCell)
        {
            int rowCount, cellCount;
            if (file.HasFile)
            {
               try
               {
                _myExcelWB = new HSSFWorkbook(file.FileContent);
                _myExcelST = (HSSFSheet)_myExcelWB.GetSheetAt(0);}
            catch
               {return null;}
               
                CellReference myCell = new CellReference(StartCell);

                if (_myExcelST != null)
                { rowCount = _myExcelST.LastRowNum; }
                else { return null; }

                IRow headerRow = _myExcelST.GetRow(myCell.Row);

                if (headerRow != null)
                {
                    cellCount = headerRow.LastCellNum;
                }
                else { return null; }

                DataTable dt = new DataTable();
                if (_myExcelST != null && rowCount > 0)
                {  
                    if (headerRow != null && cellCount > 0)
                    {
                        //表頭
                        for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                        {
                            DataColumn column = new DataColumn("Col"+i.ToString());
                            dt.Columns.Add(column);
                        }

                        //表身
                        for (int i = (headerRow.RowNum + 1); i <= _myExcelST.LastRowNum; i++)
                        {
                            HSSFRow row = (HSSFRow)_myExcelST.GetRow(i);
                            DataRow dataRow = dt.NewRow();

                            for (int j = row.FirstCellNum; j < cellCount; j++)
                            {
                                if (row.GetCell(j) != null)
                                {
                                    try
                                    {
                                        if (row.GetCell(j).CellType == CellType.NUMERIC)
                                        {
                                            DateTime myDT = row.GetCell(j).DateCellValue;
                                            if (myDT.Year > 1900 && myDT.Year < 2020)
                                            {
                                                dataRow[j] = myDT.ToString("yyyy/MM/dd HH:mm");
                                            }
                                            else
                                            {
                                                dataRow[j] = row.GetCell(j).ToString();
                                            }
                                        }
                                        else
                                        {
                                            dataRow[j] = row.GetCell(j).ToString();
                                        }
                                    }
                                    catch
                                    {
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                }
                            }
                            dt.Rows.Add(dataRow);
                        }

                    }

                    _myExcelWB = null;
                    _myExcelST = null;
                }
                return dt;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}