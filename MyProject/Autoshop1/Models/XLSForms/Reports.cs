using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Autoshop1.Models.ViewModels;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.DB;
using OfficeOpenXml;
using System.IO;

namespace Autoshop1.Models.XLSForms
{
    public class Reports
    {

        public MemoryStream ClientsReport(List<AdminUserViewModel> selUsers)
        {
            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var pck = new ExcelPackage(stream))
            {

                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");
                ws.Cells["A1"].Value = "№";
                ws.Cells["B1"].Value = "Id";
                ws.Cells["C1"].Value = "Номер";
                ws.Cells["D1"].Value = "ФИО";
                ws.Cells["E1"].Value = "Email";
                ws.Cells["F1"].Value = "Телефон";
                ws.Cells["G1"].Value = "Дата регистрации";
                ws.Cells["H1"].Value = "Роли";

                int rowstart = 2;
                foreach (var item in selUsers)
                {
                    ws.Cells[rowstart, 1].Value = item.Num;
                    ws.Cells[rowstart, 2].Value = item.Id;
                    ws.Cells[rowstart, 3].Value = item.MdbNumber;
                    ws.Cells[rowstart, 4].Value = item.UserFIO;
                    ws.Cells[rowstart, 5].Value = item.Email;
                    ws.Cells[rowstart, 6].Value = item.PhoneNumber.ToString();
                    ws.Cells[rowstart, 7].Style.Numberformat.Format = "dd-mm-yy hh:mm:ss";
                    ws.Cells[rowstart, 7].Value = item.RegistrationDate;
                    ws.Cells[rowstart, 8].Value = item.Roles;
                    rowstart++;
                }
                pck.Save();
                stream.Position = 0;

            }
            return stream;


        }

    }
}
