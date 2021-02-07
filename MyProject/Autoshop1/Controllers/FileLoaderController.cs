using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autoshop1.Models.DB;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.Vendors;
using EFCore.BulkExtensions;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Autoshop1.Controllers
{
    public class FileLoaderController : Controller
    {
        private readonly MainDBContext mdbContext;
        public FileLoaderController(MainDBContext mdb)
        {
            mdbContext = mdb;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult LoadingInfo(IFormFile file, [FromServices] /*IHostingEnvironment*/ IWebHostEnvironment environment)
        {
            string fileName = $"{environment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            var parts = this.GetPartsFromFile(file.FileName);

            int err = parts[parts.Count - 1].VendorId;
            parts.Remove(parts.Last());
            int numToLoad = parts.Count();
            LoaderToDB loader = new LoaderToDB { fileName = file.FileName, numLoaded = numToLoad, numError = err };
            using (var context = new MainDBContext())
            {
                mdbContext.BulkInsert(parts);

            }

            return View(loader);
        }

        

        private List<Part> GetPartsFromFile(string fName)
        {
            List<Part> parts = new List<Part>();
            int err=0;
            var fileName = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fName;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var con = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            FilterRow = rowReader => rowReader.Depth > 0,
                            UseHeaderRow = true
                        }
                    };


                    while (reader.Read())
                    {
                        if (reader.Depth == 0) continue;
                        double price;
                        bool priceSuccess = Double.TryParse(reader.GetValue(4).ToString(), out price);
                        double sPrice = Math.Round(price + price * 0.2);

                        try
                        {
                            parts.Add(new Part()
                            {
                                VendorId = 2,
                                Brand = reader.GetValue(0).ToString(),
                                PartNumber = reader.GetValue(1).ToString(),
                                PartName = reader.GetValue(2).ToString(),
                                QuantityInStock = Convert.ToInt32(reader.GetValue(3)),
                                BuyingPrice = Convert.ToDecimal(price),
                                SellingPrice = Convert.ToDecimal(sPrice)

                            });
                        }
                        catch (Exception)
                        {
                            err++;
                        }

                    }
                    parts.Add(new Part()
                    {
                        VendorId = err,
                        Brand = "",
                        PartNumber = "",
                        PartName = "",
                        QuantityInStock = 0,
                        BuyingPrice = 0,
                        SellingPrice = 0

                    });
                }
            }
            return parts;
        }

    }
}
