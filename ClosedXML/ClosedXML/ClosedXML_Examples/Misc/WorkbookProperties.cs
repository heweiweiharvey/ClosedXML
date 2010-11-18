﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;

using System.Drawing;

namespace ClosedXML_Examples.Misc
{
    public class WorkbookProperties
    {
        #region Variables

        // Public

        // Private


        #endregion

        #region Properties

        // Public

        // Private

        // Override


        #endregion

        #region Events

        // Public

        // Private

        // Override


        #endregion

        #region Methods

        // Public
        public void Create(String filePath)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Workbook Properties");

            wb.Properties.Author = "theAuthor";
            wb.Properties.Title = "theTitle";
            wb.Properties.Subject = "theSubject";
            wb.Properties.Category = "theCategory";
            wb.Properties.Keywords = "theKeywords";
            wb.Properties.Comments = "theComments";
            wb.Properties.Status = "theStatus";
            wb.Properties.LastModifiedBy = "theLastModifiedBy";
            wb.Properties.Company = "theCompany";
            wb.Properties.Manager = "theManager";

            wb.SaveAs(filePath);
        }

        // Private

        // Override


        #endregion
    }
}